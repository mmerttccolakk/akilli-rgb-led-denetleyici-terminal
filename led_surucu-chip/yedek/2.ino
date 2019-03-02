//serial
boolean ok=false;
String real_data,data,data_temp;

//degisken tanımlama
int led_sira, renk_pwm,red,green,blue; //rgb başlangıç için efekler içingerekli / led sıra
String renk_kodu;
//kütüphaneler
#include "FastLED.h"

//led tanımlamaları
#define DATA_PIN 13
//epromm üzerinde olucak bunlar
#define BRIGHTNESS 50
#define NUM_LEDS 300

//led sayıları tanımlanıyor
CRGB leds[NUM_LEDS];

void setup() {
  //seri ağlantı kuruluyor
  Serial.begin(115200);
  
  //güç kesinti önlemi bekle
  delay(500);
  
  //led katagorisi tanımlanıyor
  FastLED.clear(true);
  FastLED.addLeds<WS2811, DATA_PIN, RGB>(leds, NUM_LEDS);
  FastLED.setBrightness(BRIGHTNESS);

  //başlangıç çalıştırma için rgb test yapılıyor
 for( int a = 0; a < 4; a++) {
  red=0;green=0;blue=0;
  if(a==0){red = 255;}else if(a==1){ green=255; }else if(a==2){blue=255;}else{red = 255;green=255;blue=255;}
    for( int i = 0; i < NUM_LEDS; i++) {
         leds[i]= CRGB(green,red,blue);
          FastLED.show();
      }
     for( int i = NUM_LEDS; i > 0; i--) {
          leds[i] = CRGB::Black;
          FastLED.show();
     } 
  }
FastLED.clear(true);
}

void loop() {
  
  //yeni veri geliyor
  if (ok) {data_temp=real_data; real_data = ""; ok = false;}
  
  //veri parcalanıyor
  //Serial.println(data_temp);
  led_sira = data_temp.substring(1,4).toInt();
  renk_kodu= data_temp.substring(4,5);
  renk_pwm= data_temp.substring(5,8).toInt();

 String gonder = "led_sira"+String(led_sira)+"renk_kodu"+renk_kodu+"renk pwm"+String(renk_pwm);
  //Serial.println(gonder);

  leds[1] = 0xFF007F;
  FastLED.show();
}
void serialEvent(){
  while (Serial.available()){
    char temp = (char)Serial.read();
    if (temp == '\n'){ok = true;}
      real_data += temp;}
    }
