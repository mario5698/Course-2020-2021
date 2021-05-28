int led1 = 13 ;
 int led2 = 12 ; 
int led3 = 11;
void setup(){
  //iniciamos el puerto serie
  Serial.begin(9600);
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
}
 
void loop(){


  
    digitalWrite(led1,HIGH); 

    digitalWrite(led2,HIGH); 

    digitalWrite(led3,HIGH); 


}
