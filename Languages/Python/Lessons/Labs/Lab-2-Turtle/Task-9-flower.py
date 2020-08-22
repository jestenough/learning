import turtle

turtle.shape('turtle')

n = int(input("Enter the number of petals > "))
x = 1


def flower(x):
    while x <= n:
        turtle.circle(40)
        turtle.left(360 / n)
        x += 1

flower(x)

