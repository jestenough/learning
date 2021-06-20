#!/usr/bin/python3
# -*- coding: utf-8 -*-

import sys
from PyQt5.QtWidgets import QApplication, QWidget


if __name__ == '__main__':
    application = QApplication(sys.argv) # объект  приложения.  Параметр sys.argv - это список аргументов из командной строки
    window = QWidget() # основной  класс  всех  объектов  пользовательского интерфейс
    window.resize(300,150) # ширина и высота
    window.move(300,300) # перемещает на позицию
    window.setWindowTitle('Example window')
    window.show() # отображение окна на экране

    sys.exit(application.exec_())
