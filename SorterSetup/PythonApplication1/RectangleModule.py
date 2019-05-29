from GrafObjModule import GrafObj
from Tkinter import *
from __builtin__ import object
from PointModule import Point

class Rectangle(GrafObj):
    """description of class"""
    secPoint = None

    def SetAtributes(self, color, startPx, startPy, data):
        self.SetColor(color)
        self.startPoint = Point(startPx, startPy)
        self.secPoint = Point(data[0], data[1])
   
    def Draw(self, C):
        print("Crtam pravokutnik")
        C.create_rectangle(float(self.startPoint.X),float(self.startPoint.Y), float(self.secPoint.X), float(self.secPoint.Y), outline=self.GetColor(), fill="", width=2)