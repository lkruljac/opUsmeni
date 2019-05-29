from GrafObjModule import GrafObj
from Tkinter import *
from __builtin__ import object
from PointModule import Point

class Circle(GrafObj):

    radius = None

    def SetAtributes(self, color, startPx, startPy, data):
        self.SetColor(color)
        self.startPoint = Point(startPx, startPy)
        self.radius = float(data[0])
        
    def Draw(self, C):
        print("Crtam krug")
        C.create_oval(float(self.startPoint.X) - float(self.radius), float(self.startPoint.Y) - float(self.radius),  float(self.startPoint.X) + float(self.radius), float(self.startPoint.Y) + float(self.radius), outline=self.GetColor(), fill="", width=2)
        
