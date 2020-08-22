import turtle

turtle.shape("square")

x = int(input("Enter the number of squares > "))
i = 1
while i <= x:
    turtle.left(225)
    turtle.penup()
    turtle.forward((20**2/2)**0.5)
    turtle.left(135)
    turtle.pendown()
    turtle.forward(20*i)
    turtle.left(90)
    turtle.forward(20 * i)
    turtle.left(90)
    turtle.forward(20*i)
    turtle.left(90)
    turtle.forward(20*i)
    turtle.left(90)
    i+=1
