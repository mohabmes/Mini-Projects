import nltk
from nltk.corpus import gutenberg
from nltk import re
from collections import OrderedDict
from tkinter import *

possible_values = set()
valid_sent = []
sents = []
probs = {}
output = set()

def load_sents():
    global sents
    default_st = nltk.sent_tokenize

    alice = gutenberg.raw(fileids='carroll-alice.txt')
    mobyd = gutenberg.raw(fileids='melville-moby_dick.txt')
    shak1 = gutenberg.raw(fileids='shakespeare-hamlet.txt')
    shak2 = gutenberg.raw(fileids='shakespeare-macbeth.txt')
    bbkjv = gutenberg.raw(fileids='bible-kjv.txt')

    alice_sentences = default_st(text=alice)
    mobyd_sentences = default_st(text=mobyd)
    shak1_sentences = default_st(text=shak1)
    shak2_sentences = default_st(text=shak2)
    bbkjv_sentences = default_st(text=bbkjv)

    sents = alice_sentences + mobyd_sentences + shak1_sentences + shak2_sentences + bbkjv_sentences

def next_str(text, k):
    if not (k.endswith(' ') or text.endswith(' ')):
        k += " "
        text += " "
    # if not text.endswith(' '):

    res = text.split(k)
    pre = res[1].split()[0]
    return pre

def filter(text):
    res = ""
    for i in text:
        if (i>='a' and i<='z') or (i>='A' and i<='Z'):
            res += i
        else:
            break
    return res

def predict(sents, k):
    for sent in sents:
        word = next_str(sent, k)
        possible_values.add(filter(word))

def valid_sents(sents, key):
    global valid_sent
    valid_sent = [w for w in sents if re.search(key, w)]

def prob(w1, w2):
    # prob = count(w1 | w2) / count(w1)
    key = str(w1) + " " + str(w2)
    count_w1_w2 = [w for w in sents if re.search(key, w)]
    key = str(w1)
    count_w1 = [w for w in sents if re.search(key, w)]

    return len(count_w1_w2) / float(len(count_w1))

def bigram(sents):
    words = sents.split()
    p = 1
    for i in range(0, len(words)-1):
        p *= prob(words[i], words[i+1])
    return p

def main(key):
    global probs
    global output
    load_sents()
    valid_sents(sents, key)
    predict(valid_sent, key)
    for s in possible_values:
        tmp = key + " " + s
        probs[s] = bigram(tmp)

    d = OrderedDict(sorted(probs.items(), key=lambda x: x[1], reverse=True))
    print(d)

    for k in d:
        output.add(k)
    print(output)

def clear():
    possible_values.clear()
    probs.clear()
    output.clear()
    valid_sent.clear()

def func(txt):
    main(txt)
    msg = ""
    for i in output:
        msg += i + ", "
    msg = msg[:len(msg)-2]
    lbl2.config(text=msg)
    clear()

# main("going to ")
# # print(possible_values)
#
root = Tk()
root.geometry("600x200")
root.title("Text-Prediction")

lbl = Label(root, text="Sentence:")
lbl.grid(row=0, column=0, padx=12, pady=12)
txt1 = Entry(root, font=('arial', 20, 'bold'))
txt1.grid(row=0, column=1, padx=12, pady=12)

lbl2 = Label(root, text="")
lbl2.grid(row=2, column=1, padx=12, pady=12)

btn = Button(root, text="Predict", command=lambda: func(txt1.get()))
btn.grid(row=3, column=1, ipadx=20, ipady=5)
root.mainloop()
