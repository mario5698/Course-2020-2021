/*
 * Typical pin layout used:
 * -----------------------------------------------------------------------------------------
 *             MFRC522      Arduino       Arduino   Arduino    Arduino          Arduino
 *             Reader/PCD   Uno/101       Mega      Nano v3    Leonardo/Micro   Pro Micro
 * Signal      Pin          Pin           Pin       Pin        Pin              Pin
 * -----------------------------------------------------------------------------------------
 * RST/Reset   RST          9             5         D9         RESET/ICSP-5     RST
 * SPI SS      SDA(SS)      10            53        D10        10               10
 * SPI MOSI    MOSI         11 / ICSP-4   51        D11        ICSP-4           16
 * SPI MISO    MISO         12 / ICSP-1   50        D12        ICSP-1           14
 * SPI SCK     SCK          13 / ICSP-3   52        D13        ICSP-3           15
 */

#include <SPI.h>
#include <MFRC522.h>


//Definimos los pines RST Y SS(SDA)

#define RST_PIN         5     
#define SS_PIN          53         

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Creamos la instancia MFRC522

void setup() {
	Serial.begin(9600);		// Inicializamos el puerto serie
  Serial.print("AT Commands");
	while (!Serial);		// Para no ejecutar nada mientras no haya puerto serie conectado
	SPI.begin();			// Iniciar el SPI
	mfrc522.PCD_Init();		// Iniciar el MFRC522
}

void loop() {
	// Reseteamos el bucle si el sensor no recibe ninguna información nueva. Esto hace que se guarde toda la información cuando se entra en reposo.
	if ( ! mfrc522.PICC_IsNewCardPresent()) {
		return;
	}

	if ( ! mfrc522.PICC_ReadCardSerial()) {
		return;
	}
//Leemos la información de la tarjeta. Si el tamaño de la unidad de bytes es menor a 10, le añadimos un 0 delante.
 for (byte i = 0; i < mfrc522.uid.size; i++) {
  if (mfrc522.uid.uidByte[i]< 0x10){
      Serial.print("0");
    } else {
      Serial.print("");
 }
 //Imprimimos el código de tarjeta
 Serial.print(mfrc522.uid.uidByte[i]);
 }
 //Imprimimos un salto de linea
 Serial.println();
 mfrc522.PICC_HaltA();
 
 //Dump debug info about the card; PICC_HaltA() is automatically called
}
