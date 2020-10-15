#!/usr/bin/python3
# # -*- coding: utf-8 -*-
 

import sys 
from PyQt5.QtWidgets import QWidget, QMessageBox, QApplication 


class Example(QWidget): 
    def __init__(self):         
        super().__init__()         
        self.initUI() 
    
    
    def initUI(self):                        
        self.setGeometry(300, 300, 250, 150)                 
        self.setWindowTitle('Message box')             
        self.show() 
    
    
    def closeEvent(self, event):         
        reply = QMessageBox.question(self, 'Message', "Are you sure to quit?", QMessageBox.Yes | QMessageBox.No, QMessageBox.No)
        # текст  сообщения, отображаемый  с  помощью  диалогового  окна, 
        # Третий  аргумент  указывает комбинацию кнопок, появляющихся в диалоге 
        # Последний параметр – кнопка по умолчанию. Это кнопка, которая первоначально имеет на себе указатель клавиатуры
        
        if reply == QMessageBox.Yes:             
            event.accept() 
        else:             
            event.ignore()

if __name__ == '__main__':     
    app = QApplication(sys.argv)     
    ex = Example()     
    sys.exit(app.exec_())
