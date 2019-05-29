import random

shapes = ["Cube", "Cuboid", "Tethraedar", "Sphere"]
colors = ["red", "blue", "yelow", "black", "green"]

def GetObject():
      line = ""
      shape = shapes[random.randint(0,3)]
      color = colors[random.randint(0,4)]
      filter = random.randint(0, 5)
      container = random.randint(0, 5)
      weight = random.randint(0, 100)
      line = str(shape) + ";" + str(color) + ";" + str(weight) + ";" + str(filter) + ";" + str(container)
      print(line)
      return line

GetObject()
