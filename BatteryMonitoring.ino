#include<string.h>

// Print battery voltage
// to 16x2 LCD via I2C
// with Voltage Divider (2x 10K resistor)

/*
  Resistors are aligned in series.
  One end goes to Battery - and also to Arduino GND
  The other goes to Battery + and also to Arduino Vin
  The middle (connection between two resistors) goes to Arduino A0
*/
int led0 = 7; // Green LED
int led1 = 8;  // Yellow LED
int led2 = 2; // Red LED

//int sampleWire = 0;
//#include <Wire.h>
//#include <LCD.h>
//#include <LiquidCrystal_I2C.h>


void setup()
{
  Serial.begin(9600); 
  pinMode (led0, OUTPUT); //Red LED
  pinMode (led1, OUTPUT); //Yellow LED
  pinMode (led2, OUTPUT); //Green LED

  digitalWrite(led0, LOW);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  
  pinMode(A5, INPUT); // battery voltage input
  pinMode(A5, INPUT_PULLUP); //pullup resistor enables on input
}

void loop()
{
  printVolts();
}
 
 void printVolts()
{

  delay(1000);
  int sensorValue = analogRead(A5); //read the A5 pin value, which is 0-1023
  Serial.println((String)sensorValue);
  float voltage = sensorValue * (5.0 / 1023.0); //convert the value to a true voltage, 0-5 V.
  Serial.println((String)voltage);
 
 //green LED on
  if (voltage > 4) //set the voltage considered low battery here
  {
    digitalWrite(led0, HIGH);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
  }
  
  //yellow LED on
  if (voltage <= 4 && voltage >= 2.5)
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led0, LOW);
  }
  
  //red LED on
  if (voltage < 2.5)
  {
    digitalWrite(led2,HIGH);
    digitalWrite(led1, LOW);
    digitalWrite(led0, LOW);
  }
}
