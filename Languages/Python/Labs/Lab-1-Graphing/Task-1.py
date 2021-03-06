import numpy as np

for x in (1,10,100):
    x1 = 1 / np.e ** (np.sin(x) + 1)
    x2 = (5 / 4) + (1 / ((x ** 1) * 5))
    y = np.log(x1 / x2) / np.log(1 + x**2)
    print(f"Значение y в точке {x} = {'%.4f' % y}")
