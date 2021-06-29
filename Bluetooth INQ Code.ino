#include <SoftwareSerial.h>
SoftwareSerial mySerial(9, 10);
String inputString;
String NAP1;
String UAP1;
String LAP1;
String NAP2;
String UAP2;
String LAP2;
String NAP3;
String UAP3;
String LAP3;
String NAP4;
String UAP4;
String LAP4;
String NAP5;
String UAP5;
String LAP5;;
void setup() {
  // put your setup code here, to run once:


 mySerial.begin(38400);   // Setting the baud rate of GSM Module  
 Serial.begin(38400); 
  //
pinMode(8,OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:

 if (Serial.available()>0)
 switch (Serial.read()){
 case 's':
 xe();
 break; 
 case 'r':
 xe1();
 break;
  
  }


   while (mySerial.available()) {
    char inChar = (char)mySerial.read();
    inputString += inChar;
    
  }

  


 
  

}

void xe(){
  //Serial.println("Start");
 mySerial.println("AT");    //Sets the GSM Module in Text Mode
 Serial.println("1"); 
 delay(1000);
 mySerial.println("AT");    //Sets the GSM Module in Text Mode
  Serial.println("2"); 
 delay(1000);
 mySerial.println("AT+ROLE=1");    //Sets the GSM Module in Text Mode
  Serial.println("3"); 
 delay(1000);
 mySerial.println("AT+CMODE=1");    //Sets the GSM Module in Text Mode
  Serial.println("4"); 
 delay(1000);

  mySerial.println("AT+INQM=0,5,20");    //Sets the GSM Module in Text Mode
  Serial.println("5"); 
 delay(1000); 
  
 mySerial.println("AT+CLASS=0");    //Sets the GSM Module in Text Mode
  Serial.println("6"); 
 delay(1000); 
  mySerial.println("AT+NAME=ADO MALLI");    //Sets the GSM Module in Text Mode
  Serial.println("6"); 
 delay(1000);
  mySerial.println("AT+INIT");    //Sets the GSM Module in Text Mode
  Serial.println("7"); 
 delay(1000);
 mySerial.println("AT+INQ");    //Sets the GSM Module in Text Mode
 mySerial.println("AT+INQ");
  Serial.println("8"); 
  digitalWrite(8,HIGH);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);
 delay(1000);

 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);
 delay(1000);

 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);
 delay(1000);

 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);

 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);
 delay(1000);
 
 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
  delay(1000);
 delay(1000);
 
 digitalWrite(8,LOW);
  delay(1000);
  digitalWrite(8,HIGH); 
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000);
 delay(1000); 
  delay(1000);
 delay(1000);
 
  digitalWrite(8,LOW);
 Serial.println("Completed");

 
 }

 void xe1(){
int firstCommaIndex1 = inputString.indexOf(':');
int secondCommaIndex1 = inputString.indexOf(':', firstCommaIndex1+1);
int thirdCommaIndex1 = inputString.indexOf(':', secondCommaIndex1+1);

int firstCommaIndex2 = inputString.indexOf(':',thirdCommaIndex1+1);
int secondCommaIndex2 = inputString.indexOf(':', firstCommaIndex2+1);
int thirdCommaIndex2 = inputString.indexOf(':', secondCommaIndex2+1);

int firstCommaIndex3 = inputString.indexOf(':',thirdCommaIndex2+1);
int secondCommaIndex3 = inputString.indexOf(':', firstCommaIndex3+1);
int thirdCommaIndex3 = inputString.indexOf(':', secondCommaIndex3+1);

int firstCommaIndex4 = inputString.indexOf(':',thirdCommaIndex3+1);
int secondCommaIndex4 = inputString.indexOf(':', firstCommaIndex4+1);
int thirdCommaIndex4 = inputString.indexOf(':', secondCommaIndex4+1);

int firstCommaIndex5 = inputString.indexOf(':',thirdCommaIndex4+1);
int secondCommaIndex5 = inputString.indexOf(':', firstCommaIndex5+1);
int thirdCommaIndex5 = inputString.indexOf(':', secondCommaIndex5+1);

 NAP1 = inputString.substring( firstCommaIndex1+1,firstCommaIndex1+5);
 UAP1 = inputString.substring(secondCommaIndex1+1, secondCommaIndex1+3);
 LAP1 = inputString.substring(thirdCommaIndex1+1,thirdCommaIndex1+7);

 NAP2 = inputString.substring( firstCommaIndex2+1,firstCommaIndex2+5);
 UAP2 = inputString.substring(secondCommaIndex2+1, secondCommaIndex2+3);
 LAP2 = inputString.substring(thirdCommaIndex2+1,thirdCommaIndex2+7);

 NAP3 = inputString.substring( firstCommaIndex3+1,firstCommaIndex3+5);
 UAP3 = inputString.substring(secondCommaIndex3+1, secondCommaIndex3+3);
 LAP3 = inputString.substring(thirdCommaIndex3+1,thirdCommaIndex3+7);

 NAP4 = inputString.substring( firstCommaIndex4+1,firstCommaIndex4+5);
 UAP4 = inputString.substring(secondCommaIndex4+1, secondCommaIndex4+3);
 LAP4 = inputString.substring(thirdCommaIndex4+1,thirdCommaIndex4+7);

 NAP5 = inputString.substring( firstCommaIndex5+1,firstCommaIndex5+5);
 UAP5 = inputString.substring(secondCommaIndex5+1, secondCommaIndex5+3);
 LAP5 = inputString.substring(thirdCommaIndex5+1,thirdCommaIndex5+7);
 

 
 Serial.println("Text Completed"); 
 Serial.println(inputString); 
 Serial.println(NAP1+","+UAP1+","+LAP1);
 Serial.println(NAP2+","+UAP2+","+LAP2);
 Serial.println(NAP3+","+UAP3+","+LAP3);
 Serial.println(NAP4+","+UAP4+","+LAP4);
 Serial.println(NAP5+","+UAP5+","+LAP5);
  mySerial.println("AT+INQC");    //Sets the GSM Module in Text Mode
   
 delay(1000);
 mySerial.println("AT+ROLE=0");    //Sets the GSM Module in Text Mode
   
 delay(1000);
    mySerial.println("AT+INIT");   //Sets the GSM Module in Text Mode
  delay(1000);  
 delay(1000); 
  mySerial.println("AT+PAIR="+NAP1+","+UAP1+","+LAP1+",20");    //Sets the GSM Module in Text Mode
   
 delay(1000); 
 inputString = "";
  
  }
