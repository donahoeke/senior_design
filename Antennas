#include<SPI.h>
#include<RF24.h>

//Setting up the CE and CSN pins
RF24 radio(9,10);

void setup(void){
  radio.begin();//Start the radio
  radio.setPALevel(RF24_PA_MAX);
  radio.setChannel(0x76);
  radio.openWritingPipe(0xF0F0F0F0E1LL);
  radio.enableDynamicPayloads();
  radio.powerUp();

}

void loop(void) {
  // put your main code here, to run repeatedly:
//  const char text[] = "1";
//  radio.write(&text, sizeof(text));

  int potValue = analogRead(A0);
  int angleValue = map(potValue, 0, 1023, 0, 13);
  radio.write(&angleValue, sizeof(angleValue));
  
  delay(500);
  
}
