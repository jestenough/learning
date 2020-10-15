#!/usr/bin/python3
# # -*- coding: utf-8 -*-


import sys 
from PyQt5.QtWidgets import (QMainWindow, QTextEdit, QAction, QFileDialog, QApplication) 
from PyQt5.QtGui import QIcon 


class Example(QMainWindow): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
    
    def initUI(self):               
        self.textEdit = QTextEdit()         
        self.setCentralWidget(self.textEdit)         
        self.statusBar()         
        
        openFile = QAction(QIcon('open.png'), 'Open', self)         
        openFile.setShortcut('Ctrl+O')         
        openFile.setStatusTip('Open new File')         
        openFile.triggered.connect(self.showDialog)         
        
        menubar = self.menuBar()         
        fileMenu = menubar.addMenu('&File')         
        fileMenu.addAction(openFile)                
        
        self.setGeometry(300, 300, 350, 300)         
        self.setWindowTitle('File dialog') 
        self.show() 
        
        
    def showDialog(self):         
        fname = QFileDialog.getOpenFileName(self, 'Open file', '/home') # Первая строка в методе getOpenFileName() – это заголовок
        # Вторая  строка указывает диалог  рабочей папки
        # По умолчанию, файловый фильтр установлен в положение «Все файлы (*)   
        f = open(fname, 'r') # Выбранное имя файла читается и содержание файла устанавливается в виджет редактирования текста
        with f:                     
            data = f.read()             
            self.textEdit.setText(data)  
            
            
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
