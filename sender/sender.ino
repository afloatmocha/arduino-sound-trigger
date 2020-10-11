void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(2, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(7, INPUT_PULLUP);
  pinMode(8, INPUT_PULLUP);
  pinMode(9, INPUT_PULLUP);
}

void loop() {
  // put your main code here, to run repeatedly:
  if ( digitalRead(2) == LOW ) {
     Serial.print("pressed1");
     delay(500);
  }
    if ( digitalRead(3) == LOW ) {
     Serial.print("pressed2");
     delay(500);
  }
    if ( digitalRead(4) == LOW ) {
     Serial.print("pressed3");
     delay(500);
  }
    if ( digitalRead(5) == LOW ) {
     Serial.print("pressed4");
     delay(500);
  }
    if ( digitalRead(6) == LOW ) {
     Serial.print("pressed5");
     delay(500);
  }
    if ( digitalRead(7) == LOW ) {
     Serial.print("pressed6");
     delay(500);
  }
    if ( digitalRead(8) == LOW ) {
     Serial.print("pressed7");
     delay(500);
  }
    if ( digitalRead(9) == LOW ) {
     Serial.print("pressed8");
     delay(500);
  }
}
