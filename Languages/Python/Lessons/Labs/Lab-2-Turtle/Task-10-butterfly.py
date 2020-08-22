import turtle

turtle.shape('turtle')

turtle.left(90)
n = 50

def butterfly(n):
    turtle.circle(n)
    turtle.circle(-n)

x = 1
while x <= 20:
    butterfly(n)
    n += 5
    x += 1
