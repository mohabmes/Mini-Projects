import pyeemd
from numpy import loadtxt
from matplotlib.pyplot import plot, show, title
from pyeemd.utils import plot_imfs
from pyeemd import emd

egy = loadtxt("egy-pound.csv", delimiter=',', skiprows=1, usecols=1)
egy = list(reversed(egy))
imfs = emd(egy, S_number=5, num_siftings=50)
plot_imfs(imfs, plot_splines=False)
show()