# coding: utf-8
"""
Использование графического модуля graph.py.
GR_SIMPLE - простые программы
  (C) К. Поляков, 2017-2019
  e-mail: kpolyakov@mail.ru
  web: http://kpolyakov.spb.ru
"""
from graph import *

penColor(255,0,255)
penSize(5)
brushColor("blue")
rectangle(100, 100, 300, 200)
brushColor("yellow")
polygon([(100,100), (200,50),
         (300,100), (100,100)])
penColor("white")
brushColor("green")
circle(200, 150, 50)

penSize(2)
penColor("red")
oval(100, 250, 150, 350)

brushColor("yellow")
arc(200, 250, 400, 450, start = -45, end = 0 )
arc(200, 250, 400, 450, start = 0, end = 45, style = ARC )

brushColor("cyan")
arc(200, 250, 400, 450, start = 45, end = 180, style = CHORD )

run()