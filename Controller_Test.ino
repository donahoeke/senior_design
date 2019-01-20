int pot0 = A0;
int pot1 = A1;
int but0 = 2;
int but1 = 3;
int led0 = 5;
int led1 = 6;
int led2 = 4;
int led3 = 7;
int read_but0;
int read_but1;
int pot_num; 

void setup() {
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

analogWrite(led0, analogRead(pot0));
//analogWrite(led1, analogRead(pot1));

read_but0 = digitalRead(but0);
read_but1 = digitalRead(but1);
//Serial.print(read_but0);
//Serial.print("    "); 
//Serial.println(read_but1);
//Serial.print("    ");
Serial.println(analogRead(pot1));
//Serial.print("    ");
//Serial.print(analogRead(pot1));

/*if (1&&read_but0){ 
  led2 = !led2;}
else {
  led2 = led2;}

if (1&&read_but1) {
  led3 = !led3;}
else{
  led3= led3;}
 */
}
