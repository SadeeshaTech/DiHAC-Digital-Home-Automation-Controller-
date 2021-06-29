#include <EEPROM.h>
#include <SoftwareSerial.h>
String Main_page_status;
String SIM_instruction_length;
String Device_SIM_NO;
String Account_Balance_code;
String Country_Customize_code;
String User1_mobile_NO;
String User2_mobile_NO;
String User3_mobile_NO;
String User4_mobile_NO;
String User5_mobile_NO;
String User1_country_code;
String User2_country_code;
String User3_country_code;
String User4_country_code;
String User5_country_code;
String Voice_control_Instruction;
String Voice_controller_name;
String Relay1_Name;
String Relay2_Name;
String Relay3_Name;
String Relay4_Name;
String Ex_Relay1_Name;
String Ex_Relay2_Name;
String Ex_Relay3_Name;
String Ex_Relay4_Name;
String Ex_Relay5_Name;
String Ex_Relay6_Name;
String Ex_Relay7_Name;
String Ex_Relay8_Name;
String Power_OFF_code;
String Bluetooth_Instruction;
String Bluetooth_Name;
String Pairing_password;
String Baud_rate;
String MAC_address;
String User1_MAC;
String User2_MAC;
String User3_MAC;
String User4_MAC;
String User5_MAC;
String Security_Instruction;
String Emergency_Inst_Code;
String Bat_dead_voltage;
String Bat_charge_ON;
String Bat_charge_OFF;
String Weather_Com_set;
String Fire_temp;
String Low_level_temp;
String Custom1_temp;
String Custom2_temp;
String Custemp1_des;
String Custemp2_des;
String User1_identy;
String User2_identy;
String User3_identy;
String User4_identy;
String User5_identy;

void setup() {
  // put your setup code here, to run once:
Serial.begin(2400);

   
}

void loop() {
  // put your main code here, to run repeatedly:
if (analogRead(1)>700){
    delay(1000);
    read1();
    delay(1000);
  }
  
}
void read1(){
  for (int q=10;q<15;q++){
      char read1 = EEPROM.read(q);
      Main_page_status += read1;
      }

    for (int w=15;w<22;w++){
      char read2 = EEPROM.read(w);
      SIM_instruction_length += read2;
      }

    for (int e=22;e<32;e++){
      char read3 = EEPROM.read(e);
      Device_SIM_NO += read3;
      }

    for (int r=32;r<((SIM_instruction_length.substring(0, 1)).toInt())+32;r++){
     char read4 = EEPROM.read(r);    
     Account_Balance_code += read4;
    
    }

   for (int t=41;t<((SIM_instruction_length.substring(1, 2)).toInt())+41;t++){
     char read5 = EEPROM.read(t);    
    Country_Customize_code += read5;
    
    }

    for (int y=44;y<54;y++){
      char read6 = EEPROM.read(y);
      User1_mobile_NO += read6;
      }

    for (int u=54;u<64;u++){
      char read7 = EEPROM.read(u);
      User2_mobile_NO += read7;
      }

    for (int i=64;i<74;i++){
      char read8 = EEPROM.read(i);
      User3_mobile_NO += read8;
      }

    for (int o=74;o<84;o++){
      char read9 = EEPROM.read(o);
      User4_mobile_NO += read9;
      }

    for (int p=84;p<94;p++){
      char read10 = EEPROM.read(p);
      User5_mobile_NO += read10;
      }

    for (int a=94;a<((SIM_instruction_length.substring(2, 3)).toInt())+94;a++){
     char read11 = EEPROM.read(a);    
    User1_country_code += read11;
    }

    for (int s=97;s<((SIM_instruction_length.substring(3, 4)).toInt())+97;s++){
     char read12 = EEPROM.read(s);    
    User2_country_code += read12;
    }
    
    for (int d=100;d<((SIM_instruction_length.substring(4, 5)).toInt())+100;d++){
     char read13 = EEPROM.read(d);    
    User3_country_code += read13;
    }
    
    for (int f=103;f<((SIM_instruction_length.substring(5, 6)).toInt())+103;f++){
     char read14 = EEPROM.read(f);    
    User4_country_code += read14;
    }
    
    for (int g=106;g<((SIM_instruction_length.substring(6, 7)).toInt())+106;g++){
     char read15 = EEPROM.read(g);    
    User5_country_code += read15;
    }
   
    for (int h=109;h<124;h++){
      char read16 = EEPROM.read(h);
      Voice_control_Instruction += read16;
      }

   if ((Voice_control_Instruction.substring(0, 1)).toInt()!= 0){
      for (int j=124;j<((Voice_control_Instruction.substring(0, 1)).toInt())+124;j++){
      char read17 = EEPROM.read(j);
      Voice_controller_name += read17;
     }
 }
   if ((Voice_control_Instruction.substring(0, 1)).toInt()== 0){
      for (int j1=124;j1<134;j1++){
      char read17 = EEPROM.read(j1);
      Voice_controller_name += read17;
     }
 }

   if ((Voice_control_Instruction.substring(1, 2)).toInt()!= 0){
      for (int k=134;k<((Voice_control_Instruction.substring(1, 2)).toInt())+134;k++){
      char read18 = EEPROM.read(k);
      Relay1_Name += read18;
     }
 }
   if ((Voice_control_Instruction.substring(1, 2)).toInt()== 0){
      for (int k1=134;k1<144;k1++){
      char read18 = EEPROM.read(k1);
      Relay1_Name += read18;
     }
 }

    if ((Voice_control_Instruction.substring(2, 3)).toInt()!= 0){
      for (int l=144;l<((Voice_control_Instruction.substring(2, 3)).toInt())+144;l++){
      char read19 = EEPROM.read(l);
      Relay2_Name += read19;
     }
 }
   if ((Voice_control_Instruction.substring(2, 3)).toInt()== 0){
      for (int l1=144;l1<154;l1++){
      char read19 = EEPROM.read(l1);
      Relay2_Name += read19;
     }
 }

    if ((Voice_control_Instruction.substring(3, 4)).toInt()!= 0){
      for (int z=154;z<((Voice_control_Instruction.substring(3, 4)).toInt())+154;z++){
      char read20 = EEPROM.read(z);
      Relay3_Name += read20;
     }
 }
    if ((Voice_control_Instruction.substring(3, 4)).toInt()== 0){
      for (int z1=154;z1<164;z1++){
      char read20 = EEPROM.read(z1);
      Relay3_Name += read20;
     }
 }

    if ((Voice_control_Instruction.substring(4, 5)).toInt()!= 0){
      for (int x=164;x<((Voice_control_Instruction.substring(4, 5)).toInt())+164;x++){
      char read21 = EEPROM.read(x);
      Relay4_Name += read21;
     }
 }
    if ((Voice_control_Instruction.substring(4, 5)).toInt()== 0){
      for (int x1=164;x1<174;x1++){
      char read21 = EEPROM.read(x1);
      Relay4_Name += read21;
     }
 }

    if ((Voice_control_Instruction.substring(5, 6)).toInt()!= 0){
      for (int c=174;c<((Voice_control_Instruction.substring(5, 6)).toInt())+174;c++){
      char read22 = EEPROM.read(c);
      Ex_Relay1_Name += read22;
     }
 }
   if ((Voice_control_Instruction.substring(5, 6)).toInt()== 0){
      for (int c1=174;c1<184;c1++){
      char read22 = EEPROM.read(c1);
      Ex_Relay1_Name += read22;
     }
 }

    if ((Voice_control_Instruction.substring(6, 7)).toInt()!= 0){
      for (int v=184;v<((Voice_control_Instruction.substring(6, 7)).toInt())+184;v++){
      char read23 = EEPROM.read(v);
      Ex_Relay2_Name += read23;
     }
 }
    if ((Voice_control_Instruction.substring(6, 7)).toInt()== 0){
      for (int v1=184;v1<194;v1++){
      char read23 = EEPROM.read(v1);
      Ex_Relay2_Name += read23;
     }
 }

    if ((Voice_control_Instruction.substring(7, 8)).toInt()!= 0){
      for (int b=194;b<((Voice_control_Instruction.substring(7, 8)).toInt())+194;b++){
      char read24 = EEPROM.read(b);
      Ex_Relay3_Name += read24;
     }
 }
   if ((Voice_control_Instruction.substring(7, 8)).toInt()== 0){
      for (int b1=194;b1<204;b1++){
      char read24 = EEPROM.read(b1);
      Ex_Relay3_Name += read24;
     }
 }

    if ((Voice_control_Instruction.substring(8, 9)).toInt()!= 0){
      for (int n=204;n<((Voice_control_Instruction.substring(8, 9)).toInt())+204;n++){
      char read25 = EEPROM.read(n);
      Ex_Relay4_Name += read25;
     }
 }
   if ((Voice_control_Instruction.substring(8, 9)).toInt()== 0){
      for (int n1=204;n1<214;n1++){
      char read25 = EEPROM.read(n1);
      Ex_Relay4_Name += read25;
     }
 }

    if ((Voice_control_Instruction.substring(9, 10)).toInt()!= 0){
      for (int m=214;m<((Voice_control_Instruction.substring(9, 10)).toInt())+214;m++){
      char read26 = EEPROM.read(m);
      Ex_Relay5_Name += read26;
     }
 }
    if ((Voice_control_Instruction.substring(9, 10)).toInt()== 0){
      for (int m1=214;m1<224;m1++){
      char read26 = EEPROM.read(m1);
      Ex_Relay5_Name += read26;
     }
 }

    if ((Voice_control_Instruction.substring(10, 11)).toInt()!= 0){
      for (int Q=224;Q<((Voice_control_Instruction.substring(10, 11)).toInt())+224;Q++){
      char read27 = EEPROM.read(Q);
      Ex_Relay6_Name += read27;
     }
 }
   if ((Voice_control_Instruction.substring(10, 11)).toInt()== 0){
      for (int Q1=224;Q1<234;Q1++){
      char read27 = EEPROM.read(Q1);
      Ex_Relay6_Name += read27;
     }
 }

    if ((Voice_control_Instruction.substring(11, 12)).toInt()!= 0){
      for (int W=234;W<((Voice_control_Instruction.substring(11, 12)).toInt())+234;W++){
      char read28 = EEPROM.read(W);
      Ex_Relay7_Name += read28;
     }
 }
    if ((Voice_control_Instruction.substring(11, 12)).toInt()== 0){
      for (int W1=234;W1<244;W1++){
      char read28 = EEPROM.read(W1);
      Ex_Relay7_Name += read28;
     }
 }

    if ((Voice_control_Instruction.substring(12, 13)).toInt()!= 0){
      for (int E=244;E<((Voice_control_Instruction.substring(12, 13)).toInt())+244;E++){
      char read29 = EEPROM.read(E);
      Ex_Relay8_Name += read29;
     }
 }
   if ((Voice_control_Instruction.substring(12, 13)).toInt()== 0){
      for (int E1=244;E1<254;E1++){
      char read29 = EEPROM.read(E1);
      Ex_Relay8_Name += read29;
     }
 }

    if ((Voice_control_Instruction.substring(13, 14)).toInt()!= 0){
      for (int R=254;R<((Voice_control_Instruction.substring(13, 14)).toInt())+254;R++){
      char read30 = EEPROM.read(R);
      Power_OFF_code += read30;
     }
 }
   if ((Voice_control_Instruction.substring(13, 14)).toInt()== 0){
      for (int R1=254;R1<264;R1++){
      char read30 = EEPROM.read(R1);
      Power_OFF_code += read30;
     }
 }

    for (int T=264;T<270;T++){
      char read31 = EEPROM.read(T);
      Bluetooth_Instruction += read31;
      }

    if ((Bluetooth_Instruction.substring(0, 1)).toInt()== 0){
      for (int Y=270;Y<((Bluetooth_Instruction.substring(1, 2)).toInt())+270;Y++){
      char read32 = EEPROM.read(Y);
      Bluetooth_Name += read32;
     }
 }
    if ((Bluetooth_Instruction.substring(0, 1)).toInt()== 1){
      for (int Y1=270;Y1<((Bluetooth_Instruction.substring(1, 2)).toInt())+280;Y1++){
      char read32 = EEPROM.read(Y1);
      Bluetooth_Name += read32;
     }
 }

   if ((Bluetooth_Instruction.substring(0, 1)).toInt()== 2){
      for (int Y2=270;Y2<((Bluetooth_Instruction.substring(1, 2)).toInt())+290;Y2++){
      char read32 = EEPROM.read(Y2);
      Bluetooth_Name += read32;
     }
 }

    if ((Bluetooth_Instruction.substring(0, 1)).toInt()== 3){
      for (int Y3=270;Y3<((Bluetooth_Instruction.substring(1, 2)).toInt())+300;Y3++){
      char read32 = EEPROM.read(Y3);
      Bluetooth_Name += read32;
     }
 }
    
    if ((Bluetooth_Instruction.substring(2, 3)).toInt()!= 0){
      for (int U=302;U<((Bluetooth_Instruction.substring(2, 3)).toInt())+302;U++){
      char read33 = EEPROM.read(U);
      Pairing_password += read33;
     }
 }
   if ((Bluetooth_Instruction.substring(2, 3)).toInt()== 0){
      for (int U1=302;U1<312;U1++){
      char read33 = EEPROM.read(U1);
      Pairing_password += read33;
     }
 }    

     if ((Bluetooth_Instruction.substring(3, 4)).toInt()!= 0){
      for (int I=312;I<((Bluetooth_Instruction.substring(3, 4)).toInt())+312;I++){
      char read34 = EEPROM.read(I);
      Baud_rate += read34;
     }
 }
   if ((Bluetooth_Instruction.substring(3, 4)).toInt()== 0){
      for (int I1=312;I1<322;I1++){
      char read34 = EEPROM.read(I1);
      Baud_rate += read34;
     }
 }    

    for (int O=322;O<336;O++){
      char read35 = EEPROM.read(O);
      MAC_address += read35;
      }

    for (int P=336;P<350;P++){
      char read36 = EEPROM.read(P);
      User1_MAC += read36;
      }

    for (int A=350;A<364;A++){
      char read37 = EEPROM.read(A);
      User2_MAC += read37;
      }

    for (int S=364;S<378;S++){
      char read38 = EEPROM.read(S);
      User3_MAC += read38;
      }

    for (int D=378;D<392;D++){
      char read39 = EEPROM.read(D);
      User4_MAC += read39;
      }

    for (int F=392;F<406;F++){
      char read40 = EEPROM.read(F);
      User5_MAC += read40;
      }

    for (int G=406;G<414;G++){
      char read41 = EEPROM.read(G);
      Security_Instruction += read41;
      }

    if ((Security_Instruction.substring(7, 8)).toInt()!= 0){
      for (int H=414;H<((Security_Instruction.substring(7, 8)).toInt())+414;H++){
      char read42 = EEPROM.read(H);
      Emergency_Inst_Code += read42;
     }
 }
   if ((Security_Instruction.substring(7, 8)).toInt()== 0){
      for (int H1=414;H1<424;H1++){
      char read42 = EEPROM.read(H1);
      Emergency_Inst_Code += read42;
     }
 } 

    for (int J=424;J<427;J++){
      char read43 = EEPROM.read(J);
      Bat_dead_voltage += read43;
      }

     for (int K=427;K<430;K++){
      char read44 = EEPROM.read(K);
      Bat_charge_ON += read44;
      }

     for (int L=430;L<433;L++){
      char read45 = EEPROM.read(L);
      Bat_charge_OFF += read45;
      }

     for (int Z=433;Z<446;Z++){
      char read46 = EEPROM.read(Z);
      Weather_Com_set += read46;
      }

     for (int X=446;X<((Weather_Com_set.substring(0, 1)).toInt())+446;X++){
     char read47 = EEPROM.read(X);    
     Fire_temp += read47;
    
    }

     for (int C=449;C<((Weather_Com_set.substring(1, 2)).toInt())+449;C++){
     char read48 = EEPROM.read(C);    
     Low_level_temp += read48;
    
    }

    for (int V=452;V<((Weather_Com_set.substring(2, 3)).toInt())+452;V++){
     char read49 = EEPROM.read(V);    
     Custom1_temp += read49;
    
    }

    for (int B=455;B<((Weather_Com_set.substring(3, 4)).toInt())+455;B++){
     char read50 = EEPROM.read(B);    
     Custom2_temp += read50;
    
    }

    if ((Weather_Com_set.substring(4, 5)).toInt()== 0){
      for (int N=458;N<((Weather_Com_set.substring(5, 6)).toInt())+458;N++){
      char read51 = EEPROM.read(N);
      Custemp1_des += read51;
     }
 }
     if ((Weather_Com_set.substring(4, 5)).toInt()== 1){
      for (int N1=458;N1<((Weather_Com_set.substring(5, 6)).toInt())+468;N1++){
      char read51 = EEPROM.read(N1);
      Custemp1_des += read51;
     }
 }
     if ((Weather_Com_set.substring(4, 5)).toInt()== 2){
      for (int N2=458;N2<478;N2++){
      char read51 = EEPROM.read(N2);
      Custemp1_des += read51;
     }
 }

     if ((Weather_Com_set.substring(6, 7)).toInt()== 0){
      for (int M=478;M<((Weather_Com_set.substring(7, 8)).toInt())+478;M++){
      char read52 = EEPROM.read(M);
      Custemp2_des += read52;
     }
 }
     if ((Weather_Com_set.substring(6, 7)).toInt()== 1){
      for (int M1=478;M1<((Weather_Com_set.substring(7, 8)).toInt())+488;M1++){
      char read52 = EEPROM.read(M1);
      Custemp2_des += read52;
     }
 }
     if ((Weather_Com_set.substring(6, 7)).toInt()== 2){
      for (int M2=478;M2<498;M2++){
      char read52 = EEPROM.read(M2);
      Custemp2_des += read52;
     }
 }

    if ((Weather_Com_set.substring(8, 9)).toInt()!= 0){
      for (int qq=498;qq<((Weather_Com_set.substring(8, 9)).toInt())+498;qq++){
      char read53 = EEPROM.read(qq);
      User1_identy += read53;
     }
 }
   if ((Weather_Com_set.substring(8, 9)).toInt()== 0){
      for (int qq1=498;qq1<508;qq1++){
      char read53 = EEPROM.read(qq1);
      User1_identy += read53;
     }
 } 

   if ((Weather_Com_set.substring(9, 10)).toInt()!= 0){
      for (int ww=508;ww<((Weather_Com_set.substring(9, 10)).toInt())+508;ww++){
      char read54 = EEPROM.read(ww);
      User2_identy += read54;
     }
 }
   if ((Weather_Com_set.substring(9, 10)).toInt()== 0){
      for (int ww1=508;ww1<518;ww1++){
      char read54 = EEPROM.read(ww1);
      User2_identy += read54;
     }
 } 

    if ((Weather_Com_set.substring(10, 11)).toInt()!= 0){
      for (int rr=518;rr<((Weather_Com_set.substring(10, 11)).toInt())+518;rr++){
      char read55 = EEPROM.read(rr);
      User3_identy += read55;
     }
 }
    if ((Weather_Com_set.substring(10, 11)).toInt()== 0){
      for (int rr1=518;rr1<528;rr1++){
      char read55 = EEPROM.read(rr1);
      User3_identy += read55;
     }
 } 

   if ((Weather_Com_set.substring(11, 12)).toInt()!= 0){
      for (int tt=528;tt<((Weather_Com_set.substring(11, 12)).toInt())+528;tt++){
      char read56 = EEPROM.read(tt);
      User4_identy += read56;
     }
 }
    if ((Weather_Com_set.substring(11, 12)).toInt()== 0){
      for (int tt1=528;tt1<538;tt1++){
      char read56 = EEPROM.read(tt1);
      User4_identy += read56;
     }
 } 

   if ((Weather_Com_set.substring(12, 13)).toInt()!= 0){
      for (int yy=538;yy<((Weather_Com_set.substring(12, 13)).toInt())+538;yy++){
      char read57 = EEPROM.read(yy);
      User5_identy += read57;
     }
 }
    if ((Weather_Com_set.substring(12, 13)).toInt()== 0){
      for (int yy1=538;yy1<548;yy1++){
      char read57 = EEPROM.read(yy1);
      User5_identy += read57;
     }
 } 


Serial.println(Main_page_status);
Serial.println(SIM_instruction_length);
Serial.println(Device_SIM_NO);
Serial.println(Account_Balance_code);
Serial.println(Country_Customize_code);
Serial.println(User1_mobile_NO);
Serial.println(User2_mobile_NO);
Serial.println(User3_mobile_NO);
Serial.println(User4_mobile_NO);
Serial.println(User5_mobile_NO);
Serial.println(User1_country_code);
Serial.println(User2_country_code);
Serial.println(User3_country_code);
Serial.println(User4_country_code);
Serial.println(User5_country_code);
Serial.println(Voice_control_Instruction);
Serial.println("Voice_controller_name = " + Voice_controller_name);
Serial.println("Relay1_Name = " + Relay1_Name);
Serial.println("Relay2_Name = " + Relay2_Name);
Serial.println("Relay3_Name = " + Relay3_Name);
Serial.println("Relay4_Name = " + Relay4_Name);
Serial.println("Ex_Relay1_Name = " + Ex_Relay1_Name);
Serial.println("Ex_Relay2_Name = " + Ex_Relay2_Name);
Serial.println("Ex_Relay3_Name = " + Ex_Relay3_Name);
Serial.println("Ex_Relay4_Name = " + Ex_Relay4_Name);
Serial.println("Ex_Relay5_Name = " + Ex_Relay5_Name);
Serial.println("Ex_Relay6_Name = " + Ex_Relay6_Name);
Serial.println("Ex_Relay7_Name = " + Ex_Relay7_Name);
Serial.println("Ex_Relay8_Name = " + Ex_Relay8_Name);
Serial.println("Power_OFF_code = " + Power_OFF_code);
Serial.println("Bluetooth_Instruction = " + Bluetooth_Instruction);
Serial.println("Bluetooth_Name = " + Bluetooth_Name);
Serial.println("Pairing_password = " + Pairing_password);
Serial.println("Baud_rate = " + Baud_rate);
Serial.println("MAC_address = " + MAC_address);
Serial.println("User1_MAC = " + User1_MAC);
Serial.println("User2_MAC = " + User2_MAC);
Serial.println("User3_MAC = " + User3_MAC);
Serial.println("User4_MAC = " + User4_MAC);
Serial.println("User5_MAC = " + User5_MAC);
Serial.println("Security_Instruction = " + Security_Instruction);
Serial.println("Emergency_Inst_Code = " + Emergency_Inst_Code);
Serial.println("Bat_charge_ON = " + Bat_charge_ON);
Serial.println("Bat_charge_OFF = " + Bat_charge_OFF);
Serial.println("Weather_Com_set = " + Weather_Com_set);
Serial.println("Fire_temp = " + Fire_temp);
Serial.println("Low_level_temp = " + Low_level_temp);
Serial.println("Custom1_temp = " + Custom1_temp);
Serial.println("Custom2_temp = " + Custom2_temp);
Serial.println("Custemp1_des = " +Custemp1_des);
Serial.println("Custemp2_des = " +Custemp2_des);
Serial.println("User1_identy = " + User1_identy);
Serial.println("User2_identy = " + User2_identy);
Serial.println("User3_identy = " + User3_identy);
Serial.println("User4_identy = " + User4_identy);
Serial.println("User5_identy = " + User5_identy);
  }
