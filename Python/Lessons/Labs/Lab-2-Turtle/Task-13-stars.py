import turtle

turtle.shape('turtle')

n = int(input('Enter the number of vertexes: '))

def stars(n):
    turtle.left(180 - (180 / n))
    turtle.forward(200)


x = 1
while x <= n:
    stars(n)
    x += 1

turtle.done()
