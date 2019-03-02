//kütüphaneler
#include "FastLED.h"

//led tanımlamaları
#define DATA_PIN 13

//led pwm degiskenleri
byte red=0; byte green=0;byte blue=0;

//led aydınlık tanımlama epromm üzerinde olucak bunlar
#define BRIGHTNESS 100
#define NUM_LEDS 48
#define NUM_BYTES (NUM_LEDS*3) // rgb 3 renk olduğu için led*3 byte oluşturuyoruz 

//led sayi degisken ve byte sayi degisken
uint8_t led_say = 0;
uint8_t byte_say = 0;

//kaç adet led var tanımlıyoruz ve buffer tutuyoruz
CRGB leds[NUM_LEDS];
byte buffer[NUM_BYTES];

void setup() {
  //seri ağlantı kuruluyor
  Serial.begin(115200);
  Serial.setTimeout(500);
  //resetlenme ve ön bekleme ile güç kontrolü için
  delay(500);
  
  //led katagorisi tanımlanıyor
  FastLED.clear(true);
  FastLED.addLeds<WS2812B, DATA_PIN, GRB>(leds, NUM_LEDS);
  FastLED.setBrightness(BRIGHTNESS);

  //başlangıç çalıştırma için rgb test yapılıyor
 for( int a = 0; a < 4; a++) {
  red=0; green=0; blue=0;
  if(a==0){red = 255;}else if(a==1){ green=255; }else if(a==2){blue=255;}else{red = 255;green=255;blue=255;}
    for( int i = 0; i < NUM_LEDS; i++) {
         leds[i]= CRGB(red,green,blue);
          FastLED.show();
          delay(5);
      }
     for( int i = NUM_LEDS; i > 0; i--) {
          leds[i] = CRGB::Black;
          FastLED.show();
          delay(3);
     } 
  }
FastLED.clear(true);
red=0; green=0; blue=0;
}

void loop() {
  if (Serial.available() >0){Serial.readBytes(buffer, NUM_BYTES);
  
  
      while (byte_say < NUM_BYTES){
      
       byte red   = buffer[byte_say++];
       byte green = buffer[byte_say++];
       byte blue  = buffer[byte_say++];
       leds[led_say++] = CRGB(red, green, blue);
    }

    FastLED.show();

    byte_say = 0;
    led_say = 0;
  
  }


}
