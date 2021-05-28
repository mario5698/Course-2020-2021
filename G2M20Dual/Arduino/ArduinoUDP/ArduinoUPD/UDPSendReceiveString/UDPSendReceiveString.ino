#include <SPI.h>
#include <Ethernet.h>
#include <EthernetUdp.h>

IPAddress ip(192, 168, 10, 103);
IPAddress remote(192, 168, 10, 104);
int led1 = 19;
int led2 = 20;
unsigned int Port = 4321;
byte mac[] = {0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED};
byte subnet[] ={255,255,255,0};
byte gateway[] = {192,168,10,1};
byte dns[] = {8,8,8,8};
float celsius;
EthernetUDP Udp;
const int sensorPin= A8;
String value ="";
void setup() {
  Ethernet.begin(mac, ip, dns , gateway , subnet );
  Udp.begin(Port);
  Serial.begin(9600);
 pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
}

void loop() {
  int value = analogRead(sensorPin);
  float millivolts = (value / 1023.0) * 5000;
   celsius = millivolts / 10; 
  Udp.beginPacket(remote,Port );
  Udp.print(celsius);
  Udp.endPacket();

  if (celsius > 30.00){
      digitalWrite(led2,HIGH);
    }
  else{
      digitalWrite(led1,HIGH);
    }
   
   delay(1000);
  digitalWrite(led1,LOW);
  digitalWrite(led2,LOW);

}
