#include <SoftwareSerial.h>
#include <SPI.h>
#include <MFRC522.h>
SoftwareSerial miBT(10, 11); // RX | TX

//Definimos los pines RST Y SS(SDA)
#define RST_PIN         5     
#define SS_PIN          53  
MFRC522 mfrc522(SS_PIN, RST_PIN);  // Creamos la instancia MFRC522

String Data =""; 
String CodeRFID = " ";
String CodeSpaceship =" ";

void setup()
{
  Serial.begin(38400);
  Serial.print("Start");
  miBT.begin(9600);  
  while (!Serial);    // Para no ejecutar nada mientras no haya puerto serie conectado
  SPI.begin();      // Iniciar el SPI
  mfrc522.PCD_Init();   // Iniciar el MFRC522
}

void loop()
{
  while(miBT.available()){
     CodeSpaceship = miBT.readStringUntil('/n');
  }

      // Reseteamos el bucle si el sensor no recibe ninguna información nueva. Esto hace que se guarde toda la información cuando se entra en reposo.
  if ( ! mfrc522.PICC_IsNewCardPresent()) {
    CodeRFID="";
    return;
  }

  if ( ! mfrc522.PICC_ReadCardSerial()) {
    return;
  }

//Leemos la información de la tarjeta. Si el tamaño de la unidad de bytes es menor a 10, le añadimos un 0 delante.
 for (byte i = 0; i < mfrc522.uid.size; i++) {
  if (mfrc522.uid.uidByte[i]< 0x10){
  //    Serial.print("0");
    } else {
  //   Serial.print("");
 }
 //Imprimimos el código de tarjeta
int code = mfrc522.uid.uidByte[i];
CodeRFID.concat(code); 

 }
 //Imprimimos un salto de linea
 Serial.println();
 mfrc522.PICC_HaltA();

 if(CodeSpaceship != " " && CodeRFID != "" ){
  Serial.println( CodeSpaceship + CodeRFID);
   Serial.write("");
  }
}
