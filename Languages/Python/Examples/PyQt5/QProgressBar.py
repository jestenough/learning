#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# Имеем горизонтальный индикатор прогресса и кнопку. Кнопка запускает и останавливает индикатор прогресса.
import sys 
from PyQt5.QtWidgets import (QWidget, QProgressBar, QPushButton, QApplication) 
from PyQt5.QtCore import QBasicTimer 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
        
    def initUI(self):               
        self.pbar = QProgressBar(self)         
        self.pbar.setGeometry(30, 40, 200, 25)         
        self.btn = QPushButton('Start', self)         
        self.btn.move(40, 80)         
        self.btn.clicked.connect(self.doAction) 
        self.timer = QBasicTimer()   #  Чтобы активировать индикатор прогресса, мы используем объект таймера    
        self.step = 0        
        self.setGeometry(300, 300, 280, 170)         
        self.setWindowTitle('QProgressBar')         
        self.show() 
        
        
    def timerEvent(self, e): 
        if self.step >= 100:             
            self.timer.stop()             
            self.btn.setText('Finished') 
            return        
            
        self.step = self.step + 1        
        self.pbar.setValue(self.step) 
    
    
    def doAction(self): # Запускаем и останавливаем таймер.
        if self.timer.isActive():             
            self.timer.stop()             
            self.btn.setText('Start') 
        else:             
            self.timer.start(100, self) # Чтобы  запустить  событие  таймера,  мы  вызываем  его  методом  start().  
            # Этот метод  имеет  два  параметра:  таймаут,  и  объект,  который  будет  принимать события.           
            self.btn.setText('Stop') 


if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
