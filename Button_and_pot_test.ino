int pot0 = A0;
int pot1 = A1;
int but0 = 5;
int but1 = 6;
int led0 = 7;
int led1 = 2;
int led2 = 4;
int led3 = 3;
int read_but0;
int read_but1;
//int pot_num; 
int led_check;
void setup() {
//Set up the pins as inputs and outputs
  pinMode (pot0, INPUT);
  pinMode (pot1, INPUT);
  pinMode (but0, INPUT);
  pinMode (but1, INPUT);
  pinMode (led0, OUTPUT);
  pinMode (led1, OUTPUT);
  pinMode (led2, OUTPUT);
  pinMode (led3, OUTPUT);
  Serial.begin(9600);

}

void loop() {

if (led_check < 1){
digitalWrite(led0, HIGH);
digitalWrite(led1, HIGH);
digitalWrite(led2, HIGH);
digitalWrite(led3, HIGH);
delay (400);
digitalWrite(led0, LOW);
digitalWrite(led1, LOW);
digitalWrite(led2, LOW);
digitalWrite(led3, LOW);

delay(400);
led_check++;
}

//Read the analog value from the potenitometers
//write the analog value from the pot to a PWM on the LED
analogWrite(led0, analogRead(pot0));
analogWrite(led1, analogRead(pot1));

//Toggle the LEDs to be ON/OFF every time the button is pressed. 
if (digitalRead(but0)== HIGH){ 
  digitalWrite(led2, HIGH);}
else {
  digitalWrite(led2, LOW);}

if (digitalRead(but1)== HIGH) {
  digitalWrite(led3, HIGH);}
else{
  digitalWrite(led3, LOW);}

//Display Button 1 Value  Button 2 Value  Pot 1 Value   Pot 2 Value on Serial Monitor 
read_but0 = digitalRead(but0);
read_but1 = digitalRead(but1);
Serial.print(read_but0);
Serial.print("    "); 
Serial.print(read_but1);
Serial.print("    ");
Serial.print(analogRead(pot1));
Serial.print("    ");
Serial.println(analogRead(pot0));
}
