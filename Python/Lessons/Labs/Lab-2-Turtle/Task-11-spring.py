import turtle 

turtle.shape('turtle')
turtle.speed(6)

turtle.left(90)
x = 1
while x <= 5:
    turtle.circle(-60,180,100)
    turtle.circle(-10,180,100)
    x += 1

turtle.done()
