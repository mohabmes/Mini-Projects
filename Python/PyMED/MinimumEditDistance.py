from tkinter import *
import numpy


# Implementation of the Levenshtein Minimum Edit Distance
def MED(A, B):
    m = len(A)
    n = len(B)
    D = numpy.zeros((m + 1, n + 1))
    for i in range(1, m+1):
        D[i , 0] = i
    for j in range(1, n+1):
        D[0, j] = j
    for i in range(1, m+1):
        for j in range(1, n+1):
            if A[i-1] == B[j-1]:
                alpha = 0
            else:
                alpha = 2

            D[i , j ] = min(D[i - 1,j] + 1,
                                  D[i, j - 1] + 1,
                                  D[i-1, j-1] + alpha)
    print(D[1:])
    print(D[m, n])



def GUI():
    root = Tk()
    root.geometry("490x200")
    root.title("MED")

    lbl = Label(root, text="First String:")
    lbl.grid(row=0, column=0, padx=12, pady=12)
    txt1 = Entry(root, font=('arial', 20, 'bold'))
    txt1.grid(row=0, column=1, padx=12, pady=12)

    lbl2 = Label(root, text="Second String:")
    lbl2.grid(row=1, column=0, padx=12, pady=12)
    txt2 = Entry(root, font=('arial', 20, 'bold'))
    txt2.grid(row=1, column=1, padx=12, pady=12)

    btn = Button(root, text="Minimum Edit Distance", command=lambda: MED(txt1.get(), txt2.get()))
    btn.grid(row=3, column=1, ipadx=20, ipady=5)
    root.mainloop()

GUI()
