//serial
String gelen_veri;
char dizi[8];
//degisken tanımlama
int led_sira,renk_pwm,red,green,blue; //rgb başlangıç için efekler içingerekli / led sıra
String tanimlama;

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
  Serial.begin(9600);
  
  //güç kesinti önlemi bekle
  delay(500);
  
  //led katagorisi tanımlanıyor
  FastLED.clear(true);
  FastLED.addLeds<WS2811, DATA_PIN, RGB>(leds, NUM_LEDS);
  FastLED.setBrightness(BRIGHTNESS);

//  //başlangıç çalıştırma için rgb test yapılıyor
// for( int a = 0; a < 4; a++) {
//  red=0;green=0;blue=0;
//  if(a==0){red = 255;}else if(a==1){ green=255; }else if(a==2){blue=255;}else{red = 255;green=255;blue=255;}
//    for( int i = 0; i < NUM_LEDS; i++) {
//         leds[i]= CRGB(green,red,blue);
//          FastLED.show();
//      }
//     for( int i = NUM_LEDS; i > 0; i--) {
//          leds[i] = CRGB::Black;
//          FastLED.show();
//     } 
//  }
FastLED.clear(true);
}

void loop() {
  if (Serial.available() > 0) {gelen_veri = Serial.readStringUntil('.'); }
  String temp =gelen_veri;
  //veri parcalanıyor
  led_sira = temp.substring(0,3).toInt();
  tanimlama= temp.substring(3,4);
  renk_pwm = temp.substring(4,7).toInt();

 String gonder = "led_sira"+String(led_sira)+"tanimlama"+tanimlama+"renk_pwm"+String(renk_pwm);
  Serial.println(gonder);

  leds[1] = 0xFF007F;
  FastLED.show();
}
//void serialEvent(){
//  while (Serial.available()){
//    gelen_veri = Serial.readBytesUntil('.', dizi, 8);
//    }
//     for (int i = 0; i < 8; i++) { // diziyi tekrar yazmaya hazır olması için sıfırlama
//      dizi[i] = NULL;
//    }
//}
