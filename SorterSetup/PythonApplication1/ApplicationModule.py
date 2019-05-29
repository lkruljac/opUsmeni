import LikImageModule
import sys
import Tkinter


class Application(Frame):
    
    def __init__(self, master = None):
        Frame.__init__(self, master)
        self.pack()
        m = Menu(master)
        filemenu = Menu(m, tearoff=0)
        filemenu.add_command(label="Open", command=self.FunOpen)
        filemenu.add_separator()
        filemenu.add_command(label="Exit", command=self.Quit)
        m.add_cascade(label="File", menu=filemenu)
        editmenu = Menu(m, tearoff=0)
        master.config(menu=m)


    def FunOpen(self, file_path):
        root = Tk()
        root.geometry('840x640')
        app = Application(root)
        app.mainloop()
        C = Canvas(bg="gray", height=600, width=800)
        C.pack()
        i = LikImage(file_path)
        i.LoadImage(C)

    def Quit(self):
        sys.exit()
