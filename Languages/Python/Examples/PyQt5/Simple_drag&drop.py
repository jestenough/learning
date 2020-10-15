#!/usr/bin/python3
# -*- coding: utf-8 -*-

# Пример представляет простую операцию перетаскивания.
import sys
from PyQt5.QtWidgets import (QPushButton, QWidget, QLineEdit,QApplication)


class Button(QPushButton):
    def __init__(self, title, parent):
        super().__init__(title, parent)
        self.setAcceptDrops(True) # делаем возможными события перетаскивания для виджета
    
    
    def dragEnterEvent(self, e):  # сообщаем о типе данных, который мы допускаем.
        if e.mimeData().hasFormat('text/plain'): 
            e.accept()
        else:
            e.ignore()


    def dropEvent(self, e):
        self.setText(e.mimeData().text()) # меняем текст виджета кнопки 
    

class Example(QWidget):
    def __init__(self):
        super().__init__()
        self.initUI()


    def initUI(self):
        edit = QLineEdit('', self)  # Виджет QLineEdit имеет встроенную поддержку операций перетаскивания.
        edit.setDragEnabled(True)   # Все, что нам необходимо сделать – это вызвать метод setDragEnabled(),
        edit.move(30, 65)           # чтобы активировать её.
        button = Button("Button", self)
        button.move(190, 65)
        self.setWindowTitle('Simple drag & drop')
        self.setGeometry(300, 300, 300, 150)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = Example()
    ex.show()
    app.exec_()
