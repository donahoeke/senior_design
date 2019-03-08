#include<SPI.h>
#include<RF24.h>
#include<string.h>

//Setting up the CE and CSN pins
RF24 radio(9,10);
int old_potValue0 = 0;
int old_potValue1 = 0;


void setup(void){
  Serial.begin(9600);
  radio.begin();//Start the radio
  radio.setPALevel(RF24_PA_MAX);//Setting the Power Amplification Level
  radio.setChannel(0x76);//Setting channel
  radio.openWritingPipe(0xF0F0F0F0E1LL);//Open the sending address
  radio.enableDynamicPayloads();//Enable dynamic payloads
  radio.powerUp();//Power up the radio

  Serial.println("You are Here!");
}
void loop(void) {
  int potValue0 = analogRead(A0);
  int potValue1 = analogRead(A1);
  Serial.println("pv1 " + (String)potValue1);
  int angleValue0 = 100 + map(potValue0, 0, 1023, 3, 12);
  int angleValue1 = 200 + map(potValue1, 0, 1020, 3, 12);

  Serial.println("av0 " + (String)potValue0 + "Old " + (String)old_potValue0);
  Serial.println("av1 " + (String)potValue1 + "Old " + (String)old_potValue1);
  
  if(potValue0 > old_potValue0 + 5 || potValue0 < old_potValue0-5)
  {
      radio.write(&angleValue0, sizeof(angleValue0));//Send the message
      delay(1200);
  }

  if(potValue1 > old_potValue1 + 5 || potValue1 < old_potValue1-5)
  {
      radio.write(&angleValue1, sizeof(angleValue1));//Send the message
      delay(1200);
  }
  //float angleValue1 = (13.0/1023.0)*potValue1;

  old_potValue0 = potValue0;
  old_potValue1 = potValue1;

}
