

#include <EEPROM.h>
#include <SoftwareSerial.h>
SoftwareSerial mySerial(2, 3);
SoftwareSerial mySerial1(4, 5);
SoftwareSerial mySerial2(6, 7);
SoftwareSerial mySerial3(8, 9);
SoftwareSerial mySerial4(10, 11);


String inputString = "";
String prevString = "";
int stringComplete = false;
int x=10;
String SM_1;
String OneorMany1;
String macnumber1;
String No_digits1;
String D_name1;
String D_password1;
String D_rate1;

String SM_2;
String OneorMany2;
String macnumber2;
String No_digits2;
String D_name2;
String D_password2;
String D_rate2;

String SM;
String OneorMany;
String macnumber;
String No_digits;
String D_name;
String D_password;
String D_rate;

String state;
String state1;
void setup()
{
 Serial.begin(2400);
 mySerial.begin(38400);
 mySerial1.begin(38400);
 mySerial2.begin(38400);
 mySerial3.begin(38400);
 mySerial4.begin(38400);
// delay(1000);
    pinMode(12,OUTPUT);
    
    digitalWrite(12,LOW);
    char read27 = EEPROM.read(226);
      state1 = read27;

      if (state1.toInt()== 1){
        read1();
        }

      if (state1.toInt()== 2){
        read2();
        }
   
 }



void loop()
{
   while (Serial.available()>0) {
    char inChar = (char)Serial.read();
int  y= int(inChar);
    EEPROM.write(x,y);
    x= x+1;
    inputString += inChar;
    //Serial.println(x);
    if (x==227) {
      stringComplete = true;
      x=10;
    // read1();
      
    }
  }

  
    
}

void read1(){
  delay(1000);
  digitalWrite(12,HIGH);
  
 char read1 = EEPROM.read(10);
      SM = read1;
      char read2 = EEPROM.read(11);
      OneorMany = read2;
      for (int i=12;i<26;i++){
      char read3 = EEPROM.read(i);
      macnumber += read3;
      }

      for (int r=26;r<30;r++){
      char read4 = EEPROM.read(r);
      No_digits += read4;
      }

      ///////////////////////////////////////
 if ((No_digits.substring(0, 1)).toInt()== 0){
   for (int t=30;t<((No_digits.substring(1, 2)).toInt())+30;t++){
     char read5 = EEPROM.read(t);
     //Serial.println(read4);
    D_name += read5;
    
    }
 }
 if ((No_digits.substring(0, 1)).toInt()== 1){
   for (int t=30;t<((No_digits.substring(1, 2)).toInt())+40;t++){
     char read5 = EEPROM.read(t);
     //Serial.println(read4);
    D_name += read5;
    
    }
 }
  if ((No_digits.substring(0, 1)).toInt()== 2){
   for (int t=30;t<((No_digits.substring(1, 2)).toInt())+50;t++){
     char read5 = EEPROM.read(t);
     //Serial.println(read4);
    D_name += read5;
    
    }
 }
  if (((No_digits.substring(0, 1)).toInt()== 3)&& ((No_digits.substring(1, 2)).toInt()!= 2)){
   for (int t=30;t<((No_digits.substring(1, 2)).toInt())+60;t++){
     char read5 = EEPROM.read(t);
     //Serial.println(read4);
    D_name += read5;
    
    }
 }
 if (((No_digits.substring(0, 1)).toInt()== 3)&& ((No_digits.substring(1, 2)).toInt()== 2)){
  for (int tt=30;tt<62;tt++){
     char read5 = EEPROM.read(tt);
    D_name += read5;
  
  }
 }
 /////////////////////////////////////

 if ((No_digits.substring(2, 3)).toInt()!= 0){
   for (int s=62;s<((No_digits.substring(2, 3)).toInt())+62;s++){
     char read6 = EEPROM.read(s);
    // Serial.println(read5);
    D_password += read6;
    
    }
 }
 else if ((No_digits.substring(2, 3)).toInt()== 0){
  for (int ss=62;ss<72;ss++){
     char read6 = EEPROM.read(ss);
    D_password += read6;
  
  }
 }
 //////////////////////////////////////////////////////////

 if ((No_digits.substring(3, 4)).toInt()!= 0){
   for (int u=72;u<((No_digits.substring(3, 4)).toInt())+72;u++){
     char read7 = EEPROM.read(u);
     //Serial.println(read6);
    D_rate += read7;
    
    }
 }
  else if ((No_digits.substring(3, 4)).toInt()== 0){
  for (int uu=72;uu<82;uu++){
    char read7 = EEPROM.read(uu);
    D_rate += read7;
  
  }
 }
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

   char read8 = EEPROM.read(82);
      SM_1 = read8;
      char read9 = EEPROM.read(83);
      OneorMany1 = read9;
      for (int p=84;p<98;p++){
      char read10 = EEPROM.read(p);
      macnumber1 += read10;
      }

      for (int pp=98;pp<102;pp++){
      char read11 = EEPROM.read(pp);
      No_digits1 += read11;
      }

      ///////////////////////////////////////
 if ((No_digits1.substring(0, 1)).toInt()== 0){
   for (int d=102;d<((No_digits1.substring(1, 2)).toInt())+102;d++){
     char read12 = EEPROM.read(d);
     //Serial.println(read4);
    D_name1 += read12;
    
    }
 }
else if ((No_digits1.substring(0, 1)).toInt()== 1){
   for (int d=102;d<((No_digits1.substring(1, 2)).toInt())+112;d++){
     char read12 = EEPROM.read(d);
     //Serial.println(read4);
    D_name1 += read12;
    
    }
 }
 else if ((No_digits1.substring(0, 1)).toInt()== 2){
   for (int d=102;d<((No_digits1.substring(1, 2)).toInt())+122;d++){
     char read12 = EEPROM.read(d);
     //Serial.println(read4);
    D_name1 += read12;
    
    }
 }
 else if (((No_digits1.substring(0, 1)).toInt()== 3)&& ((No_digits1.substring(1, 2)).toInt()!= 2)){
   for (int d=102;d<((No_digits1.substring(1, 2)).toInt())+132;d++){
     char read12 = EEPROM.read(d);
     //Serial.println(read4);
    D_name1 += read12;
    
    }
 }
 else if (((No_digits1.substring(0, 1)).toInt()== 3)&& ((No_digits1.substring(1, 2)).toInt()== 2)){
  for (int e=102;e<134;e++){
     char read12 = EEPROM.read(e);
    D_name1 += read12;
  
  }
 }
 /////////////////////////////////////

 if ((No_digits1.substring(2, 3)).toInt()!= 0){
   for (int k=134;k<((No_digits1.substring(2, 3)).toInt())+134;k++){
     char read13 = EEPROM.read(k);
    // Serial.println(read5);
    D_password1 += read13;
    
    }
 }
 if ((No_digits1.substring(2, 3)).toInt()== 0){
  for (int f=134;f<144;f++){
     char read13 = EEPROM.read(f);
    D_password1 += read13;
  
  }
 }
 //////////////////////////////////////////////////////////

 if ((No_digits1.substring(3, 4)).toInt()!= 0){
   for (int v=144;v<((No_digits1.substring(3, 4)).toInt())+144;v++){
     char read14 = EEPROM.read(v);
     //Serial.println(read6);
    D_rate1 += read14;
    
    }
 }
   if ((No_digits1.substring(3, 4)).toInt()== 0){
  for (int b=144;b<154;b++){
    char read14 = EEPROM.read(b);
    D_rate1 += read14;
  
  }
 }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

  char read15 = EEPROM.read(154);
      SM_2 = read15;
      char read16 = EEPROM.read(155);
      OneorMany2 = read16;
      for (int h=156;h<170;h++){
      char read17 = EEPROM.read(h);
      macnumber2 += read17;
      }

      for (int hh=170;hh<174;hh++){
      char read18 = EEPROM.read(hh);
      No_digits2 += read18;
      }

      ///////////////////////////////////////
 if ((No_digits2.substring(0, 1)).toInt()== 0){
   for (int hhh=174;hhh<((No_digits2.substring(1, 2)).toInt())+174;hhh++){
     char read19 = EEPROM.read(hhh);
     //Serial.println(read4);
    D_name2 += read19;
    
    }
 }
if ((No_digits2.substring(0, 1)).toInt()== 1){
   for (int hhh=174;hhh<((No_digits2.substring(1, 2)).toInt())+184;hhh++){
     char read19 = EEPROM.read(hhh);
     //Serial.println(read4);
    D_name2 += read19;
    
    }
 }
 if ((No_digits2.substring(0, 1)).toInt()== 2){
   for (int hhh=174;hhh<((No_digits2.substring(1, 2)).toInt())+194;hhh++){
     char read19 = EEPROM.read(hhh);
     //Serial.println(read4);
    D_name2 += read19;
    
    }
 }
 if (((No_digits2.substring(0, 1)).toInt()== 3)&& ((No_digits2.substring(1, 2)).toInt()!= 2)){
   for (int hhh=174;hhh<((No_digits2.substring(1, 2)).toInt())+204;hhh++){
     char read19 = EEPROM.read(hhh);
     //Serial.println(read4);
    D_name2 += read19;
    
    }
 }
 if (((No_digits2.substring(0, 1)).toInt()== 3)&& ((No_digits2.substring(1, 2)).toInt()== 2)){
  for (int hhhh=174;hhhh<206;hhhh++){
     char read20 = EEPROM.read(hhhh);
    D_name2 += read20;
  
  }
 }
 /////////////////////////////////////

 if ((No_digits2.substring(2, 3)).toInt()!= 0){
   for (int j=206;j<((No_digits2.substring(2, 3)).toInt())+206;j++){
     char read21 = EEPROM.read(j);
    // Serial.println(read5);
    D_password2 += read21;
    
    }
 }
 if ((No_digits2.substring(2, 3)).toInt()== 0){
  for (int jj=206;jj<216;jj++){
     char read22 = EEPROM.read(jj);
    D_password2 += read22;
  
  }
 }
 //////////////////////////////////////////////////////////

 if ((No_digits2.substring(3, 4)).toInt()!= 0){
   for (int jjj=216;jjj<((No_digits2.substring(3, 4)).toInt())+216;jjj++){
     char read23 = EEPROM.read(jjj);
     //Serial.println(read6);
    D_rate2 += read23;
    
    }
 }
  if ((No_digits2.substring(3, 4)).toInt()== 0){
  for (int jjjj=216;jjjj<226;jjjj++){
    char read24 = EEPROM.read(jjjj);
    D_rate2 += read24;
  
  }
 }

 char read25 = EEPROM.read(226);
      state = read25;
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 
      
 mySerial.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT+NAME="+D_name);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT+PSWD="+D_password);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT+UART="+D_rate+",0,0");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT+ROLE="+SM);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT+CMODE="+OneorMany);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT+BIND="+macnumber);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT+UART="+D_rate+",0,0");    //Sets the GSM Module in Text Mode
 delay(1000);
  mySerial1.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

  mySerial2.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT+NAME="+D_name);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT+PSWD="+D_password);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT+UART="+D_rate+",0,0");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT+ROLE="+SM);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT+CMODE="+OneorMany);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT+BIND="+macnumber);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT+UART="+D_rate+",0,0");    //Sets the GSM Module in Text Mode
 delay(1000);
  mySerial3.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

 mySerial4.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+NAME="+D_name2);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+PSWD="+D_password2);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+ROLE="+SM_2);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+CMODE="+OneorMany2);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+BIND="+macnumber2);    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+UART="+D_rate2+",0,0");    //Sets the GSM Module in Text Mode
 delay(1000);
  mySerial4.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

  digitalWrite(12,LOW);
  SM = "";
  OneorMany="";
  macnumber="";
  No_digits="";
 D_name=""; 
 D_password="";
 D_rate="";
   SM_1 = "";
  OneorMany1="";
  macnumber1="";
  No_digits1="";
 D_name1=""; 
 D_password1="";
 D_rate1="";
 SM_2 = "";
  OneorMany2="";
  macnumber2="";
  No_digits2="";
 D_name2=""; 
 D_password2="";
 D_rate2="";
 state = "";
 EEPROM.write(226,0);
 delay(1000);
 
  }

  void read2(){
digitalWrite(12,HIGH);
  delay(1000);
  delay(1000);
  mySerial.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial.println("AT+ORGL");    //Sets the GSM Module in Text Mode
 delay(1000); 
  mySerial.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 
 
 mySerial1.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial1.println("AT+ORGL");    //Sets the GSM Module in Text Mode
 delay(1000);
  mySerial1.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000);  

 mySerial2.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial2.println("AT+ORGL");    //Sets the GSM Module in Text Mode
 delay(1000); 
  mySerial2.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

 mySerial3.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial3.println("AT+ORGL");    //Sets the GSM Module in Text Mode
 delay(1000); 
  mySerial3.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

 mySerial4.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT");    //Sets the GSM Module in Text Mode
 delay(1000);
 mySerial4.println("AT+ORGL");    //Sets the GSM Module in Text Mode
 delay(1000); 
  mySerial4.println("AT+RESET");    //Sets the GSM Module in Text Mode
 delay(1000); 

  EEPROM.write(226,0);
 digitalWrite(12,LOW);
 
  }




  
