#!/usr/bin/python3
# -*- coding: utf-8 -*-

# Текст,который мы вбиваем в строку редактирования, немедленно отображается в виджете метки.
import sys
from PyQt5.QtWidgets import (QWidget, QLabel, QLineEdit, QApplication)


class Example(QWidget):
    def __init__(self):
        super().__init__()
        self.initUI()


    def initUI(self):
        self.lbl = QLabel(self)
        qle = QLineEdit(self)
        qle.move(60, 100)
        self.lbl.move(60, 40)
        qle.textChanged[str].connect(self.onChanged) # Если текст в виджете редактирования строки меняется, мы вызываем метод onChanged().
        self.setGeometry(300, 300, 280, 170)
        self.setWindowTitle('QLineEdit')
        self.show()

        
    def onChanged(self, text):
        self.lbl.setText(text)
        self.lbl.adjustSize() # чтобы приспосабливать размер метки к длине текста.


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = Example()
    sys.exit(app.exec_())
