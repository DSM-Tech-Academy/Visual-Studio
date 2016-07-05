from tkinter import *
from tkinter import ttk
from tkinter import messagebox
import os, sqlite3
import webbrowser


class Creatinghtml():

    def __init__(self, master):
        #-------------------------------------------------------
        # Creating 2 tabs in order to change from Pre made web pages to create your own side
        notebook = ttk.Notebook(master)
        notebook.pack()
        CYO = ttk.Frame(notebook)                     # CREATE YOUR OWN
        PMP = ttk.Frame(notebook)                  # PRE MADE PAGE
        notebook.add(CYO, text = 'Create own')
        notebook.add(PMP, text = 'Use premade')

        #--------------------------------------------------------
        #                Section is for CYO TAB
        
        #--------------------
        # Setup spacing
        paddingx = 10

        #-----------------------
        #  Setup for Welcome and instructions
        welcome_label = ttk.Label(CYO, text = 'Simple Webpage Creator')
        welcome_label.config(font = ('Helvetica', 20))
        welcome_label.grid(row = 0, column = 0, columnspan = 4, sticky = 'n')
        welcome2 = ttk.Label(CYO, text = "Your file will be created in C:\\html\\") 

        welcome2.grid(row = 1, column = 1, columnspan = 2)
        welcome3 =  ttk.Label(CYO, text = '')
        
        
        #----------------------
        #  Setup File Naming area
        filelabel = ttk.Label(CYO, text = 'File Name:')
        filelabel.grid(    row = 3, column = 1, sticky = 'nw', padx = paddingx)
        self.fileName = ttk.Entry(CYO, width = 30)
        self.fileName.grid(row = 4, column = 1, sticky = 'nw', padx = paddingx)

        #----------------------
        #  Setup body text area
        bodyLabel = ttk.Label(CYO, text = 'Body text:')
        bodyLabel.grid(   row = 5, column = 1, sticky = 'w', padx = paddingx)
        self.bodytext = Text(CYO, width = 50, height = 10)
        self.bodytext.config(wrap = 'word')
        self.bodytext.grid(    row = 6, column = 1, columnspan = 3, padx = paddingx)

        #---------------------
        #  Setup for submit button
        submit = ttk.Button(CYO, text = 'Create Page', command = lambda: self.clickBotton(1))
        submit.grid(row = 7, column = 3, pady = 5)
        
        #  Ends CYO SECTION 
        #-------------------------------------------------------------------------
            
        #------------------------------------------------------------------------
        #                  STAERTS PMP SECTION

        welcome1 = ttk.Label(PMP, text = 'Simple Webpage Creator')
        welcome1.config(font = ('Helvetica', 20))
        welcome1.grid(row = 0, column = 0, columnspan = 4, sticky = 'n')
        welcome5 = ttk.Label(PMP, text = "Your file will be created in C:\\html\\")
        
        #----------------------
        #  Setup File Naming area
        PMPfilelabel = ttk.Label(PMP, text = 'File Name:')
        PMPfilelabel.grid(    row = 3, column = 1, sticky = 'nw', padx = paddingx)
        self.fileName1 = ttk.Entry(PMP, width = 30)
        self.fileName1.grid(row = 4, column = 1, sticky = 'nw', padx = paddingx)

        #-----------------------
        #   Setup for radioButtons
        c = sqlite3.connect("C:\\html\\pmp.db")
        lines = c.execute("SELECT string FROM Premade").fetchall()
        self.indexRow = 5
        self.radio = StringVar()
        for index, l in enumerate(lines):
            l1 = str(l)
            line = l1.strip("('),")
            ttk.Radiobutton(PMP, text = '{}'.format(line), variable = self.radio, value = '{}'.format(line)).grid( row = index + 5, column = 1, sticky = 'w')
            self.indexRow += 1

        #-----------------------------------
        #   Setup of Create Page button
        submit1 = ttk.Button(PMP, text = 'Create Page', command = lambda: self.clickBotton(2))
        submit1.grid(row = self.indexRow, column = 3, pady = 15)

    def clickBotton(self, request):
        if(request == 1):
            name = self.fileName.get()
            body = self.bodytext.get('1.0', 'end')
        else:
            name = self.fileName1.get()
            body = self.radio.get()
            print(body)
        print('B: {}'.format(body))
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
        output.close()
        webbrowser.open(oFile)
        messagebox.showinfo(title = 'Thank you for using Webpage Creator', message = 'Your file is ready at {}'.format(oFile))



def creating_db():
    c = sqlite3.connect("C:\\html\\pmp.db")
    #c.execute("CREATE TABLE Premade (ID INT PRIMARY KEY, string text)")
    c.execute("INSERT INTO Premade ('string') VALUES ('Its a New Year, We will have new bargains next week')")
    c.execute("INSERT INTO Premade ('string') VALUES ('Happy Birthday Mr. Washington, New bargains on the way');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Love is in the Air, Can we get something for the love birds?');")
    c.execute("INSERT INTO Premade ('string') VALUES ('It is time to say thank you to our fallen troops!');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Summer is almost here, time for getting outside.');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Summer is almost over, We will return in the Fall');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Free Labor day fun, come join us');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Fall feastival is here Have fun at the main offices');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Trick or Treat, I hope I get a treat');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Thanks for all the things God has given us');")
    c.execute("INSERT INTO Premade ('string') VALUES ('Christmas is here and we are on vacation. Thanks');")
    c.commit()      

def printdb():
    c = sqlite3.connect('C:\\html\\pmp.db')
    l = c.execute("SELECT string FROM Premade").fetchall()
    print(l)
#creating_db()
#printdb()


def main():
    master = Tk()
    done = Creatinghtml(master)
    master.mainloop()

if __name__ == "__main__": main()
        