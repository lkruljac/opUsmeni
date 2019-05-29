
#include <SoftwareSerial.h>

#include <stdio.h>
#include <string.h>

// RX, TX
SoftwareSerial mySerial(13, 12); 


void writeString(String stringData) { // Used to serially push out a String with Serial.write()

  for (int i = 0; i < stringData.length(); i++)
  {
    Serial.write(stringData[i]);   // Push each char 1 by 1 on each loop pass
  }

}// end writeString



void writeMessage(String color, String shape, int filter, int weight, int container) { // Used to serially push out a String with Serial.write()

  for (int i = 0; i < shape.length(); i++)
  {
    Serial.write(shape[i]);   // Push each char 1 by 1 on each loop pass
  }
  Serial.write(";");
  for (int i = 0; i < color.length(); i++)
  {
    Serial.write(shape[i]);   // Push each char 1 by 1 on each loop pass
  }
  Serial.write(";");
  Serial.write(filter);
  Serial.write(";");
  Serial.write(weight);
  Serial.write(";");
  Serial.write(container); 
}

void myWriteMessage(String color, String shape, int filter, int weight, int container) { // Used to serially push out a String with Serial.write()

  for (int i = 0; i < shape.length(); i++)
  {
    mySerial.print(shape[i]);   // Push each char 1 by 1 on each loop pass
  }
  mySerial.print(';');
  for (int i = 0; i < color.length(); i++)
  {
    mySerial.print(color[i]);   // Push each char 1 by 1 on each loop pass
  }
  mySerial.print(';');
  mySerial.print(filter);
  mySerial.print(';');
  mySerial.print(weight);
  mySerial.print(';');
  mySerial.print(container); 
  mySerial.println();
}

String shapes[] = {"Cube", "Cuboid", "Tethraedar", "Sphere"} ;//0-3
String colors[] = {"red", "blue", "yelow", "black", "green"} ;//0-4



void setup() {
  Serial.begin(9600);
  mySerial.begin(9600);
  pinMode(11, OUTPUT);
}

void loop() { // run over and over
  if (mySerial.available()) {
    String buffer;
    buffer = mySerial.readString();
    writeString(buffer);
    //mySerial.write("radi");
    String color;
    String shape;
    if(buffer.equals("START\n")){      
      for(int i=0; i<20; i++){
        shape = shapes[(rand()%3)];
        color = colors[(rand()%4)];
        myWriteMessage(shape, color, rand()%5, rand()%5, rand()%6); 
      }
      buffer = "End";
      mySerial.println(buffer);
    }
  }
}
