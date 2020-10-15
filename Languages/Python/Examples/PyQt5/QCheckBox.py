#!/usr/bin/python3
# # -*- coding: utf-8 -*-

# создаю чекбокс, который переключает заголовок окна.

import sys 
from PyQt5.QtWidgets import QWidget, QCheckBox, QApplication 
from PyQt5.QtCore import Qt 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
    
    def initUI(self):               
        cb = QCheckBox('Show title', self)         
        cb.move(20, 20)         
        cb.toggle()         # По умолчанию, заголовок окна не установлен и чекбокс выключен
        cb.stateChanged.connect(self.changeTitle) # связываем пользователя, определяющего метод changeTitle(), с сигналом stateChanged
        
        self.setGeometry(300, 300, 250, 150)         
        self.setWindowTitle('CheckBox PyQT5')         
        self.show() 

    def changeTitle(self, state):  # Метод changeTitle() будет переключать заголовок окна
        if state == Qt.Checked: # Если виджет помечен галочкой           
            self.setWindowTitle('Test, lulz') # мы устанавливаем заголовок окна 
        else:             
            self.setWindowTitle('') # В противном случае, мы устанавливаем пустую строку в заголовке.
            
            
if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_()) 
