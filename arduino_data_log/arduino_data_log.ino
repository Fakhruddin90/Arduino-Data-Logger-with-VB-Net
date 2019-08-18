int LDR1;
int LDR2;
int Pot;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int LDR1=analogRead(A2);
  Serial.print("L1");Serial.println(LDR1);
  int LDR2=analogRead(A1);
  Serial.print("L2");Serial.println(LDR2);
  int Pot=analogRead(A0);
  Serial.print("Pt");Serial.println(Pot);
  delay(1000);
}
