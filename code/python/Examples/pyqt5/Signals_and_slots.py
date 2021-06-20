#!/usr/bin/python3
# -*- coding: utf-8 -*-


import sys 
from PyQt5.QtCore import Qt 
from PyQt5.QtWidgets import (QWidget, QLCDNumber, QSlider, QVBoxLayout, QApplication) 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
        
    def initUI(self):         
        lcd = QLCDNumber(self)         
        sld = QSlider(Qt.Horizontal, self)         
        vbox = QVBoxLayout()         
        vbox.addWidget(lcd)         
        vbox.addWidget(sld)         
        self.setLayout(vbox)         
        sld.valueChanged.connect(lcd.display) # соединяем сигнал valueChanged слайдера к слоту display числа lcd        
        self.setGeometry(300, 300, 250, 150)         
        self.setWindowTitle('Signal & slot')         
        self.show() 
        
        
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
