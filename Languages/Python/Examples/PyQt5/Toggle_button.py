#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# создаём  три  кнопки  переключателя  и  QWidget.  
# устанавливаем  чёрный  цвет  фона  QWidget.  Кнопки  переключателей  будут переключать красные, зелёные и синие части значений цвета. 
# Цвет фона будет зависеть от того, на какие кнопки переключателей мы нажали.

import sys 
from PyQt5.QtWidgets import (QWidget, QPushButton, QFrame, QApplication) 
from PyQt5.QtGui import QColor 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    
    
    def initUI(self):               
        self.col = QColor(0, 0, 0)  # Это начальное, чёрное значение цвета.             
        redb = QPushButton('Red', self)         
        redb.setCheckable(True)   # делаем его проверяемым      
        redb.move(10, 10)         
        redb.clicked[bool].connect(self.setColor) # привязываем сигнал к нашему пользовательскому методу. 
                                                  # Мы используем сигнал clicked, который работает с логическим значением      
        redb = QPushButton('Green', self)         
        redb.setCheckable(True)         
        redb.move(10, 60)         
        redb.clicked[bool].connect(self.setColor)         
        
        blueb = QPushButton('Blue', self)         
        blueb.setCheckable(True)         
        blueb.move(10, 110)         
        blueb.clicked[bool].connect(self.setColor)         
        
        self.square = QFrame(self)         
        self.square.setGeometry(150, 20, 100, 100)         
        self.square.setStyleSheet("QWidget { background-color: %s }" %               
        self.col.name())         
        self.setGeometry(300, 300, 280, 170)         
        self.setWindowTitle('Toggle button')         
        self.show() 
        
    
    def setColor(self, pressed):         
        source = self.sender()  # получаем кнопку, которая была переключена
        if pressed:             
            val = 255
        else: 
            val = 0
    
        if source.text() == "Red":         # случае красной кнопки
            self.col.setRed(val)           # мы обновляем красную часть цвета соответственно     
        elif source.text() == "Green":             
            self.col.setGreen(val)             
        else:             
            self.col.setBlue(val)          
        
        self.square.setStyleSheet("QFrame { background-color: %s }" % self.col.name())   
        
        
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example() 
    sys.exit(app.exec_()) 
