#include<SPI.h>
#include<RF24.h>

//Setting up the CE and CSN pins
RF24 radio(9,10);

void setup(void){
  radio.begin();//Start the radio
  radio.setPALevel(RF24_PA_MAX);//Setting the Power Amplification Level
  radio.setChannel(0x76);//Setting channel
  radio.openWritingPipe(0xF0F0F0F0E1LL);//Open the sending address
  radio.enableDynamicPayloads();//Enable dynamic payloads
  radio.powerUp();//Power up the radio
}
void loop(void) {
  const char text[] = "Radio Communication Test";//Create a message
  radio.write(&text, sizeof(text));//Send the message
  delay(1000);
}
