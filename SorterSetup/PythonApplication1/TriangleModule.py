from GrafObjModule import GrafObj
from Tkinter import *
from __builtin__ import object
from PointModule import Point

class Triangle(GrafObj):

    secPoint = None
    thrPoint = None


    def SetAtributes(self, color, startPx, startPy, data):
        self.SetColor(color)      
        self.startPoint = Point(startPx, startPy)
        self.secPoint = Point(data[0], data[1])
        self.thrPoint = Point(data[2], data[3])

    def Draw(self, C):
        print("Crtam trokut")
        points = []
        points = [self.startPoint.X, self.startPoint.Y, self.secPoint.X, self.secPoint.Y, self.thrPoint.X, self.thrPoint.Y]
        C.create_polygon(points, outline=self.GetColor(), fill="", width=2)