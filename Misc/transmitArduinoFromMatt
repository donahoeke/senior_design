//still needs testing by kt
void record();
void damera();

#include<SPI.h>
#include<RF24.h>
#include<string.h>

//Setting up the CE and CSN pins
RF24 radio(9,10);

//keeps track of last potentiomer value for comparison with new potentiometer values
int old_potValue0 = 0;
int old_potValue1 = 0;
int but0 = 5; // Red button-Record button
int but1 = 6;  // White button-Picture Button

//Three LEDs for battery monitoring
int led0 = 0; // Green LED
int led1 = 1;  // Yellow LED
int led2 = 2; // Red LED


//Two LEDs are camera functioning LEDs
int led3 = 3; // Red Record LED
int led4 = 4; //Yellow Picture taken LED


int read_but0; //Red button
int read_but1; //White button

int pot_num; 
int bright;

void setup(void){
  //Buttons as inputs
  pinMode (but0, INPUT); //Red button
  pinMode (but1, INPUT); //White button
  //Record and Camera lights as outputs
  pinMode (led3, OUTPUT); //Red Record LED
  pinMode (led4, OUTPUT);//Yellow Picture taken LED
  //Begin serial monitor for debugging
  Serial.begin(9600); 
  //Antenna setup
  radio.begin();//Start the radio
  radio.setPALevel(RF24_PA_MAX);//Setting the Power Amplification Level
  radio.setChannel(0x76);//Setting channel
  radio.openWritingPipe(0xF0F0F0F0E1LL);//Open the sending address
  radio.enableDynamicPayloads();//Enable dynamic payloads
  radio.powerUp();//Power up the radio
}
void loop(void) {
  record();
  camera();
  
  //read the potentiometer values
  int potValue0 = analogRead(A0);
  int potValue1 = analogRead(A1);
  
  //converts the values to range from 3-12 (which is representative of duty cycle) instead of 0-1023, and appends a 1 or 2 
  //to the front, based on whether it is potentiometer 1 or 2
  int angleValue0 = 100 + map(potValue0, 0, 1023, 3, 12);
  int angleValue1 = 200 + map(potValue1, 0, 1020, 3, 12);
  
  //prints for debugging purposes
  Serial.println("New av0 value: " + (String)potValue0 + "Old av0 value: " + (String)old_potValue0);
  Serial.println("New av1 value: " + (String)potValue1 + "Old av1 value: " + (String)old_potValue1);
  
  //Sends a signal over radio if the new potentiometer 0 value is different than the old one (with a small range built in)
  if(potValue0 > old_potValue0 + 5 || potValue0 < old_potValue0-5)
  {
      radio.write(&angleValue0, sizeof(angleValue0));//Send the message
      delay(1200);
  }
  
  //Sends a signal over radio if the new potentiometer 1 value is different than the old one (with a small range built in)
  if(potValue1 > old_potValue1 + 5 || potValue1 < old_potValue1-5)
  {
      radio.write(&angleValue1, sizeof(angleValue1));//Send the message
      delay(1200);
  }
  //float angleValue1 = (13.0/1023.0)*potValue1;

  old_potValue0 = potValue0;
  old_potValue1 = potValue1;
}
void record()
{
  read_but0 = digitalRead(but0);
  if(read_but0 == 1)//Pressing the record button
  {
    delay(1000);
    read_but0 = digitalRead(but0);
    while (read_but0 == 0)
    {
    int recordValue1 = 1000 + map(1, 0, 0, 0, 0);
    radio.write(&recordValue1, 1);//Send the message
        digitalWrite(led3, HIGH);
        delay(250);       
        digitalWrite(led3, LOW);        
        delay(250);       
        digitalWrite(led3, HIGH);       
        delay(250);       
        digitalWrite(led3, LOW);
        read_but0 = digitalRead(but0);
        delay(500);
        if(read_but0 == 1)
        {
          read_but0 == 2;
        }
    }
  }
}

void camera()
{
  read_but1 = digitalRead(but1);//Camera button(white)
  if (1&&read_but1)//Pressing camera button flashes twice
  {
    int cameraValue1 = 300 + map(1, 0, 0, 0,0);
     radio.write(&cameraValue1, 1);//Send the message
  
    delay(1200);
    digitalWrite(led4, HIGH);
    delay(1200);
    digitalWrite(led4, LOW);
      
  }
}
