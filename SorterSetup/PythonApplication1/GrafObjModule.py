from PointModule import Point

class GrafObj(object):
    """description of class"""

    color = None
    startPoint = None

    def GetColor(self):
         return self.color
    
    def SetColor(self, color):
        self.color    = color

    def __init__(self, *args, **kwargs):
        return super(GrafObj, self).__init__(*args, **kwargs)
  