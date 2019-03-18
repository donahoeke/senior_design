int pot0 = A0;//Purple wire
int pot1 = A1;//White wire
int but0 = 3; // Red button
int but1 = 4;  // White button
int led0 = 5; // Green LED
int led1 = 6;  // Red LED
int led2 = 7; // Blue LED
int led3 = 8; // Yellow LED
int read_but0; //Red button
int read_but1; //White button
int pot_num; 
int bright;

void setup() {
  pinMode (pot0, INPUT); //Potentiometer 1
  pinMode (pot1, INPUT); //Potentiometer 2
  pinMode (but0, INPUT); //Red button
  pinMode (but1, INPUT); //White button
  pinMode (led0, OUTPUT); //Green LED
  pinMode (led1, OUTPUT); //Red LED
  pinMode (led2, OUTPUT); //Blue LED
  pinMode (led3, OUTPUT); //Yellow LED
 Serial.begin(9600);
 
}

void loop() {
  read_but0 = digitalRead(but0);
  read_but1 = digitalRead(but1);
  if (1&&read_but0)
  {
    digitalWrite(led0, HIGH);
    delay(100);
    digitalWrite(led0, LOW);
    
  }
  if (1&&read_but1)
  {
    digitalWrite(led0, HIGH);
    delay(100);
    digitalWrite(led0, LOW);
    
  }
  //read_but1 = digitalRead(but1);//Read White
 //analogWrite(led0, analogRead(pot0));
