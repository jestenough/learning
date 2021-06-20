#!/usr/bin/python3
# # -*- coding: utf-8 -*-


import sys 
from PyQt5.QtWidgets import (QWidget, QGridLayout, QPushButton, QApplication)

class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
        
    
    def initUI(self):         
        grid = QGridLayout()         
        self.setLayout(grid)         
        # макет окна приложения
        names = ['Cls', 'Bck', '', 'Close', '7', '8', '9', '/', '4', '5', '6', '*', '1', '2', '3', '-', '0', '.', '=', '+']
        # метки для кнопок           
        positions = [(i,j) for i in range(5) for j in range(4)]
        # список позиций для сетки
        for position, name in zip(positions, names): 
            if name == '': 
                continue            
            button = QPushButton(name)             
            grid.addWidget(button, *position) # метод addWidget, создает и добавляет кнопки к макету      
        
        self.move(300, 150)         
        self.setWindowTitle('Calculator')         
        self.show()

if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
