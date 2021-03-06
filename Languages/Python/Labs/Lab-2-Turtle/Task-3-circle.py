import turtle 

turtle.shape('circle')

x = 1
while True:
    turtle.forward(3)
    turtle.left(2)
    if (x%180) == 1:
        turtle.clear()
    x += 1
