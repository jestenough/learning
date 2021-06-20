#!/usr/bin/python3
# # -*- coding: utf-8 -*-
 

import sys 
from PyQt5.QtWidgets import QMainWindow, QAction, qApp, QApplication 
from PyQt5.QtGui import QIcon 


class Example(QMainWindow): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    
    
    def initUI(self):                        
        exitAction = QAction(QIcon('exit.png'), '&Выход', self)                 
        exitAction.setShortcut('Ctrl+Q')         
        exitAction.setStatusTip('Выход из программы') #  подсказку,  которая  показывается  в  строке  состояния         
        exitAction.triggered.connect(qApp.quit) # инициирующий сигнал.  Сигнал  присоединяют  к  методу  quit()  виджета  QApplication    
        self.statusBar()         
        
        menubar = self.menuBar() # создаём строку меню   
        fileMenu = menubar.addMenu('&Файл')     
        fileMenu.addAction(exitAction) # Выход из приложения
        
        self.setGeometry(300, 300, 300, 200)         
        self.setWindowTitle('Menubar')             
        self.show()


if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
