#!/usr/bin/python3
# # -*- coding: utf-8 -*-

import sys 
from PyQt5.QtWidgets import QApplication, QWidget 
from PyQt5.QtGui import QIcon

class Example(QWidget): 
    def __init__(self):         
        super().__init__()  # super()  возвращает  объект  родителя  класса  Example  и  мы вызываем его конструктор
        self.init_UI() # Метод __init__() – это конструктор класса в языке Python

    def init_UI(self):         
        self.setGeometry(300, 300, 300, 220) # Первые два параметра – позиции x и y нашего окна. Третий – ширина, и четвёртый – высота окна  
        self.setWindowTitle('application icon')         
        self.setWindowIcon(QIcon('web.png'))   # иконка              
        self.show()


if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
