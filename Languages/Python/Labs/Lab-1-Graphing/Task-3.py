import numpy as np
import matplotlib.pyplot as plt

x = np.arange(-10,10,0.01)

sin_2 = (1 - np.cos(2 * x)) / 2
plt.plot(x, np.log((x*x + 1) * np.exp(-(np.abs(x) / 10))) / np.log(1 + np.tan (1 / (1 + sin_2))))
plt.show()
