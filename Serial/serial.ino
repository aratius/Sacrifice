const int TOP = 4;
bool top = false;
String topName = "top";

const int BOTTOM = 2;
bool bottom;
String bottomName = "bottom";

const int LEFT = 5;
bool left = false; 
String leftName = "left";

const int RIGHT = 3;
bool right = false;
String rightName = "right";


void setup() {
  Serial.begin(9600);
  pinMode(LEFT, INPUT);
}

void loop() {
  bool _left = checkButton(LEFT, left, leftName);
  if(_left) left = !left;

  bool _top = checkButton(TOP, top, topName);
  if(_top) top = !top;

  bool _right = checkButton(RIGHT, right, rightName);
  if(_right) right = !right;

  bool _bottom = checkButton(BOTTOM, bottom, bottomName);
  if(_bottom) bottom = !bottom;
  
  delay(10);
}

bool checkButton(int pinNumber, bool isShining, String key){
  if(digitalRead(pinNumber) == HIGH && !isShining) {
    SendSerial(key, 1);
    return true;
  }else if(digitalRead(pinNumber) == LOW && isShining) {
    SendSerial(key, 0);
    return true;
  }
  return false;
}

void SendSerial(String key, int val) {
  Serial.print(key);
  Serial.print("\t");
  Serial.print(val);
  Serial.print("\t");
  Serial.println();
}
