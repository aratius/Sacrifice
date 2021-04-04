
const int LEFT = 2;
bool left = false; 


void setup() {
  Serial.begin(9600);
  pinMode(LEFT, INPUT);
}

void loop() {
  bool _left = checkButton(LEFT, left);
  if(_left) left = !left;
  delay(10);
}

bool checkButton(int pinNumber, bool isShining){
  if(digitalRead(pinNumber) == HIGH && !isShining) {
    Serial.println("button state became high");
    return true;
  }else if(digitalRead(pinNumber) == LOW && isShining) {
    Serial.println("button state became low");
    return true;
  }
  return false;
}
