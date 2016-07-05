#     t k P h o n e . p y

from tkinter import *
import pickle
#from phones  import *
try:
    phonelist = pickle.load( open( "save.p", "rb" ) )
    if(len(phonelist) < 1): raise ValueError('No File')
except:
    from phones import *
def whichSelected () :
    print("At {} of {}".format(select.curselection(), len(phonelist)))
    return int(select.curselection()[0])

def addEntry () :
    phonelist.append ([nameVar.get(), phoneVar.get()])
    setSelect ()

def updateEntry() :
    phonelist[whichSelected()] = [nameVar.get(), phoneVar.get()]
    setSelect ()

def deleteEntry() :
    del phonelist[whichSelected()]
    setSelect ()

def loadEntry  () :
    name, phone = phonelist[whichSelected()]
    nameVar.set(name)
    phoneVar.set(phone)
def saveAll () :
    save_file = open('phones1.py', 'w')
    idx = 0
    print("phonelist = [", file = save_file)
    for k, v in phonelist:
        idx +=1
        if (idx < len(phonelist)): print("  ['{}' : '{}'],".format(k, v), file = save_file)
        else:print("  ['{}' : '{}']".format(k, v), file = save_file)
    print("]", file = save_file)
    save_file.close()

def save_pickle():
     pickle.dump( phonelist, open( "save.p", "wb" ) )

def makeWindow () :
    global nameVar, phoneVar, select
    win = Tk()

    frame1 = Frame(win)
    frame1.pack()

    Label(frame1, text="Name").grid(row=0, column=0, sticky=W)
    nameVar = StringVar()
    name = Entry(frame1, textvariable=nameVar)
    name.grid(row=0, column=1, sticky=W)

    Label(frame1, text="Phone").grid(row=1, column=0, sticky=W)
    phoneVar= StringVar()
    phone= Entry(frame1, textvariable=phoneVar)
    phone.grid(row=1, column=1, sticky=W)

    frame2 = Frame(win)       # Row of buttons
    frame2.pack()
    b1 = Button(frame2,text=" Add  ",command=addEntry)
    b2 = Button(frame2,text="Update",command=updateEntry)
    b3 = Button(frame2,text="Delete",command=deleteEntry)
    b4 = Button(frame2,text=" Load ",command=loadEntry)
    b5 = Button(frame2, text = "Save", command = save_pickle)
    b1.pack(side=LEFT); b2.pack(side=LEFT)
    b3.pack(side=LEFT); b4.pack(side=LEFT)
    b5.pack(side = LEFT)

    frame3 = Frame(win)       # select of names
    frame3.pack()
    scroll = Scrollbar(frame3, orient=VERTICAL)
    select = Listbox(frame3, yscrollcommand=scroll.set, height=6)
    scroll.config (command=select.yview)
    scroll.pack(side=RIGHT, fill=Y)
    select.pack(side=LEFT,  fill=BOTH, expand=1)
    return win

def setSelect () :
    phonelist.sort()
    select.delete(0,END)
    for name,phone in phonelist :
        select.insert (END, name)

win = makeWindow()
setSelect ()
win.mainloop()

