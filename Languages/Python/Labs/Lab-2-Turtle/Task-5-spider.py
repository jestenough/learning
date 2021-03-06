import turtle

turtle.shape('turtle')

n = int(input("Enter the number of spider legs > "))

x = 1
while True:
    turtle.forward(150)
    turtle.stamp()
    turtle.backward(150)
    turtle.right(360/n)
    x+=1

    if x%n == 1:
        turtle.clear()
