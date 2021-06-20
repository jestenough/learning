#!/usr/bin/python3
# # -*- coding: utf-8 -*-

import sys 
from PyQt5.QtWidgets import (QWidget, QToolTip, QPushButton, QApplication) 
from PyQt5.QtGui import QFont     


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    

    def initUI(self):         
        QToolTip.setFont(QFont('Times New Roman', 8)) # устанавливаю  шрифт, используемый  для  показа всплывающих подсказок
         
        btn = QPushButton('Кнопка', self)         
        btn.setToolTip('Это наша <b> кнопка </b> :)')  # Мы можем использовать HTML форматирование текста       
        btn.resize(btn.sizeHint())  # Метод  sizeHint()  даёт рекомендуемый размер для кнопки    
        btn.move(50, 50)                

        self.setToolTip('Это наше <b>окно</b> :)') 
        self.setGeometry(300, 300, 300, 200)         
        self.setWindowTitle('Tooltips')             
        self.show()


if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
