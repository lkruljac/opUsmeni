from GrafObjModule import GrafObj
from Tkinter import *
from __builtin__ import object
from PointModule import Point

class Line(GrafObj):
    secPoint = None

    def SetAtributes(self, color, startPx, startPy, data):
        self.SetColor(color)
        self.startPoint = Point(startPx, startPy)
        self.secPoint = Point(data[0], data[1])
    def Draw(self, C):
        print("Crtam Liniju")
        C.create_line(float(self.startPoint.X),float(self.startPoint.Y), float(self.secPoint.X), float(self.secPoint.Y), fill=self.GetColor(),  width=2)