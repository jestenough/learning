#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# Когда  мы  кликаем  на  окне  курсором  мыши,  срабатывает  сигнал  closeApp. Приложение завершается

import sys 
from PyQt5.QtCore import pyqtSignal, QObject 
from PyQt5.QtWidgets import QMainWindow, QApplication 


class Communicate(QObject):     
    closeApp = pyqtSignal()   # создание сигнала
    

class Example(QMainWindow): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    
    
    def initUI(self):               
        self.c = Communicate()         
        self.c.closeApp.connect(self.close)                
        self.setGeometry(300, 300, 290, 150)         
        self.setWindowTitle('Emit signal')         
        self.show() 
        
    
    def mousePressEvent(self, event):         
        self.c.closeApp.emit() 
        
        
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
