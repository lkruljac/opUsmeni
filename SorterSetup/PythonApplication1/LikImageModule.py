from GrafObjModule import GrafObj
from CircleModule import Circle
from RectangleModule import Rectangle
from LineModule import Line
from TriangleModule import Triangle
class LikImage(object):
    """description of class"""
    path = ""
    
    def __init__(self, path):
        self.path = path
        return super(LikImage, self).__init__()

    def LoadImage(self, C):
       
        with open(self.path) as fp:  
           line = fp.readline()
           cnt = 1
           while line:
               #parsing
               line=line.split()
               shape = line[0]
               color = line[1]
               startPointY = line[3]
               startPointX = line[2]
               data = line[4:] 

               print("\nShape: " + shape + "\nColor: " + color + "\nStart point(" + startPointX +", " + startPointY + ")" + "\nOther data: ")
               print(data)
               #drawing
               
               if(shape=="Circle"):
                  obj = Circle()
                  obj.SetAtributes(color, startPointX, startPointY, data)
                  obj.Draw(C)
               elif(shape == "Ellipse"):
                    obj = Ellipse()
                    obj.SetAtributes(color, startPointX, startPointY, data)
                    obj.Draw(C)
               elif(shape == "Polygon"):
                    obj = Polygone()
                    obj.SetAtributes(color, startPointX, startPointY, data)
                    obj.Draw(C)
               
               elif(shape == "Line"):
                    obj = Line()
                    obj.SetAtributes(color, startPointX, startPointY, data)
                    obj.Draw(C)
               elif(shape == "Triangle"):
                    obj = Triangle()
                    obj.SetAtributes(color, startPointX, startPointY, data)
                    obj.Draw(C)

               elif(shape == "Rectangle"):
                    obj = Rectangle()
                    obj.SetAtributes(color, startPointX, startPointY, data)
                    obj.Draw(C)

               #next iteration
               line = fp.readline()
               cnt += 1
