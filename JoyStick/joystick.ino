//const int TOP = 4;
//bool top = false;

const int BOTTOM = 2;
bool bottom;

const int LEFT = 5;
bool left = false; 

const int RIGHT = 3;
bool right = false;


void setup() {
  Serial.begin(9600);
  pinMode(LEFT, INPUT);
}

void loop() {
  bool _left = checkButton(LEFT, left);
  if(_left) left = !left;

//  bool _top = checkButton(TOP, top);
//  if(_top) top = !top;

  bool _right = checkButton(RIGHT, right);
  if(_right) right = !right;

  bool _bottom = checkButton(BOTTOM, bottom);
  if(_bottom) bottom = !bottom;
  
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
