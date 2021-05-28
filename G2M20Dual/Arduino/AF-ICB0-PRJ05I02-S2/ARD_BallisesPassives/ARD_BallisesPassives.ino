int led1 = 11;
int led2 = 12;
int led3 = 13;
int Divisor;
int Ciclos;
int data [2] ; 
bool EsPar;
bool conect=false; 
void setup()
{
 Serial.begin(9600);
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);  
}

void loop(){

if (Serial.available()>0){

  String numero= Serial.readString();
separarNumeros(numero);

connectado();

espar();

     
cerrar();
}
}

void espar(){
  int ciclos = data[0];
  int divisor = data[1];
    for(int i=0; i<=ciclos; i++){
      if( i % divisor == 0 && i %2 ==0 ){
        digitalWrite(led1,HIGH);
        digitalWrite(led2,HIGH);
        delay(2000);  
      }else if (i %2 ==0 ){
        digitalWrite(led1,HIGH);          
        delay(2000);  
        
        }

    if( i % divisor == 0 && i %2 !=0 ){
        digitalWrite(led3,HIGH);  
        digitalWrite(led2,HIGH);
        delay(2000);  
      }else if (i %2 !=0 ){
        digitalWrite(led3,HIGH);          
        delay(2000);  
      }
      /*
      if(i % 2 == 0){
        digitalWrite(led1,HIGH);
        delay(2000);
      }else{
        digitalWrite(led3,HIGH);
        delay(2000);  
     }
      */
      digitalWrite(led1,LOW);
      digitalWrite(led2,LOW);
      digitalWrite(led3,LOW);
 }
}


void separarNumeros(String frase){
  for(int i =0; i< 2 ;i++){
    int index = frase.indexOf(';');
    data[i] = frase.substring(0,index).toInt();
    frase = frase.substring(index+1);
  }   
}


void cerrar (){
  digitalWrite(led1,LOW);
      digitalWrite(led2,LOW);
      digitalWrite(led3,LOW);
  delay(5000);
  }

void connectado(){
if(!conect  && data[0] == 0){
      digitalWrite(led1,HIGH);
      digitalWrite(led2,HIGH);
      digitalWrite(led3,HIGH);
        delay(5000);
        conect = true;
}
 
  
}
