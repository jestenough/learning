import turtle
from math import sin, cos, pi, radians

t = turtle.Pen()
NOSE_HEIGHT = 0.3
NOSE_WIDTH = 0.1

SMILE_WIDTH = 0.1
SMILE_RADIUS = 0.4
SMILE_LENGTH = 180
SMILE_OFFSET = 0.3

EYE_ALFA = 45
EYE_RIDIUS = 0.15
EYE_OFFSET = 0.65

def main():
    r0 = int(input("Enter the radius"))
    x0 = int(input("Enter the x of the center: "))
    y0 = int(input("Enter the y of the center: ")))
    t.penup
    morda_draw(x0, y0, r0)
    draw_yeies(x0, y0, r0)
    draw_nose(x0, y0, r0)
    draw_smile(x0, y0, r0)
    t.exitonclick()
    return 0

def morda_draw(x, y, r):
    t.color('yellow')
    t.begin_fill()
    arc_my(x, y, r)
    t.end_fill()
    return 0

def arc_my(x, y, r, a = 0, l = 0):
    t.penup()
    t.goto(x, y - r)
    t.pendown()
    t.circle(r)  
    return 0


def draw_yeies(x0, y0, r0):
    a = EYE_ALFA
    x1 = x0 + cos(pi/180*a) * (r0 * EYE_OFFSET)
    x2 = x0 - cos(pi/180*a) * (r0 * EYE_OFFSET)
    y1 = y0 + sin(pi/180*a) * (r0 * EYE_OFFSET)
    r = r0 * EYE_RIDIUS
    t.color('blue')
    t.begin_fill()
    arc_my(x1, y1, r)
    t.end_fill()
    t.begin_fill()
    arc_my(x2, y1, r)
    t.end_fill()
    return 0

def draw_nose(x0, y0, r0):
    w = r0 * NOSE_WIDTH
    h = r0 * NOSE_HEIGHT
    t.penup()
    t.left(90)
    t.goto(x0,y0)
    t.color('black')
    t.pendown()
    t.width(w)
    t.forward(h/2)
    t.backward(h)
    return 0

def draw_smile(x0, y0, r0):
    w = r0 * SMILE_WIDTH
    r = r0 * SMILE_RADIUS
    a = r0 * SMILE_OFFSET
    x = x0 + r
    y = y0 - a
    l = SMILE_LENGTH
    t.width(w)
    t.penup()
    t.goto(x,y)
    t.color('red')
    t.pendown()
    t.circle(r, -l)
    return 0

main()
