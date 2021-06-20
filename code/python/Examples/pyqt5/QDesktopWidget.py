#!/usr/bin/python3
# # -*- coding: utf-8 -*-
 
# Центрируем окно на экране.
import sys 
from PyQt5.QtWidgets import QWidget, QDesktopWidget, QApplication 

class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    
    
    def initUI(self):                        
        self.resize(500, 350)         
        self.center()         
        self.setWindowTitle('Center')             
        self.show() 
        
        
    def center(self):         
        qr = self.frameGeometry()   # получаем прямоугольник, точно определяющий форму главного окна        
        cp = QDesktopWidget().availableGeometry().center() # выясняем разрешение экрана нашего монитора. 
                                                           # Из этого разрешения, мы получаем центральную точку      
        qr.moveCenter(cp)  # Устанавливаем центр прямоугольника в центр экрана. Размер прямоугольника не изменяется
        self.move(qr.topLeft()) 


if __name__ == '__main__':     
    app = QApplication(sys.argv)
    ex = Example()     
    sys.exit(app.exec_())
