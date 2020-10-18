
def greet(name):
    print("hello, " + name,end="?\n")
    greet2(name)
    print("getting ready to say bye...")
    bye()

def greet2(name):
    print("how r u, " + name, end="?\n")

def bye():
    print("ok bye!")


greet('slavik')
