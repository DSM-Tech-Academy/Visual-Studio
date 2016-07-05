from tkinter import *
from tkinter import ttk
from tkinter import messagebox
import os


class Creatinghtml():

    def __init__(self, master):
        #--------------------
        # Setup spacing
        paddingx = 10

        #-----------------------
        #  Setup for Welcome and instructions
        welcome_label = ttk.Label(master, text = 'Simple Webpage Creator')
        welcome_label.config(font = ('Helvetica', 20))
        welcome_label.grid(row = 0, column = 0, columnspan = 4, sticky = 'n')
        welcome2 = ttk.Label(master, text = "Your file will be created in C:\\html\\") 

        welcome2.grid(row = 1, column = 1, columnspan = 2)
        welcome3 =  ttk.Label(master, text = '')
        
        
        #----------------------
        #  Setup File Naming area
        filelabel = ttk.Label(master, text = 'File Name:')
        filelabel.grid(    row = 3, column = 1, sticky = 'nw', padx = paddingx)
        self.fileName = ttk.Entry(master, width = 30)
        self.fileName.grid(row = 4, column = 1, sticky = 'nw', padx = paddingx)

        #----------------------
        #  Setup body text area
        bodyLabel = ttk.Label(master, text = 'Body text:')
        bodyLabel.grid(   row = 5, column = 1, sticky = 'w', padx = paddingx)
        self.bodytext = Text(master, width = 50, height = 10)
        self.bodytext.config(wrap = 'word')
        self.bodytext.grid(    row = 6, column = 1, columnspan = 3, padx = paddingx)


        #---------------------
        #  Setup for submit button
        submit = ttk.Button(master, text = 'Create Page', command = lambda: self.clickBotton())
        submit.grid(row = 7, column = 3, pady = 5)
    
    def clickBotton(self):
        name = self.fileName.get()
        body = self.bodytext.get('1.0', 'end')
        if(name == ''):
            messagebox.showinfo(title = 'Please enter a file name:', message = 'before the file can be created, it needs a name.')
            return False 
        oFile = 'C:\\html\\{}.html'.format(name)
        #-------------------------------------------------
        # Check if file is already in folder
        if os.path.isfile(oFile):
            messagebox.showinfo(title = 'Please enter a file name:', message = 'file with that name already made.')
            return False
       
        output = open(oFile, 'w')
        print("<html>\n <head>\n  <title>{}</title> \n </head>\n".format(name), file = output)
        print("<body> \n", file = output)
        print("<p>\n{} </p> \n ".format(body), file = output)
        print("</body> \n \n</html>", file = output)
        messagebox.showinfo(title = 'Thank you for using Webpage Creator', message = 'Your file is ready at {}'.format(oFile))

      



def main():
    master = Tk()
    done = Creatinghtml(master)
    master.mainloop()

if __name__ == "__main__": main()
        