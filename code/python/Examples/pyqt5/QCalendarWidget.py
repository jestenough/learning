#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# Пример имеет виджет календаря и виджет метки. Текущая выбранная дата отображается в виджете метки
import sys 
from PyQt5.QtWidgets import (QWidget, QCalendarWidget, QLabel, QApplication) 
from PyQt5.QtCore import QDate 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
        
    def initUI(self):               
        cal = QCalendarWidget(self)         
        cal.setGridVisible(True)         
        cal.move(20, 20)         
        cal.clicked[QDate].connect(self.showDate)  # Если мы выбираем дату из виджета, срабатывает сигнал clicked[QDate]. 
        # Мы присоединяем этот сигнал к определённому пользователем методу showDate().       
        
        self.lbl = QLabel(self)         
        date = cal.selectedDate()         
        self.lbl.setText(date.toString())         
        self.lbl.move(130, 260)         
        self.setGeometry(300, 300, 350, 300)         
        self.setWindowTitle('Calendar')         
        self.show() 
    
    
    def showDate(self, date):              
        self.lbl.setText(date.toString()) 
        # Мы возвращаем выбранную дату путём вызова метода selectedDate()
        # Тогда мы превращаем объект даты в строку и устанавливаем его в виджет метки.

if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
