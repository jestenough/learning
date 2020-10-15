#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# Симулируем   контроль   громкости. Путём перетаскивания регулятора ползунка, мы меняем изображение на метке. 
import sys 
from PyQt5.QtWidgets import (QWidget, QSlider, QLabel, QApplication) 
from PyQt5.QtCore import Qt 
from PyQt5.QtGui import QPixmap 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
    
    def initUI(self):               
        sld = QSlider(Qt.Horizontal, self)      # Создаём горизонтальный QSlider   
        sld.setFocusPolicy(Qt.NoFocus)         
        sld.setGeometry(30, 40, 100, 30)         
        sld.valueChanged[int].connect(self.changeValue) # Привязываем сигнал valueChanged к определенному пользователем методу changeValue().        
        self.label = QLabel(self)         
        self.label.setPixmap(QPixmap('mute.png'))         
        self.label.setGeometry(160, 40, 80, 30)         
        self.setGeometry(300, 300, 280, 170)         
        self.setWindowTitle('QSlider')         
        self.show() 
    
    
    def changeValue(self, value): 
        if value == 0:             
            self.label.setPixmap(QPixmap('mute.png')) 
        elif value > 0 and value <= 30:             
            self.label.setPixmap(QPixmap('min.png')) 
        elif value > 30 and value < 80:             
            self.label.setPixmap(QPixmap('med.png')) 
        else:             
            self.label.setPixmap(QPixmap('max.png')) 
        
        # Основываясь на значении ползунка, мы устанавливаем изображение на метку. 
        # В  коде  выше,  мы  устанавливаем  изображение  mute.png  на  метку,  
        # если ползунок приравнен к нулю. 
            
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
