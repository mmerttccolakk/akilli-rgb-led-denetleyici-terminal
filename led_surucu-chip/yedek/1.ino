//serial
boolean ok=false;
String real_data,data,data_temp;
Serial.setTimeout(3000);//dene test edilmedi

//degisken tanımlama
int led_sira, renk_pwm;
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
  delay(2000);
  
  //led katagorisi tanımlanıyor
  FastLED.clear(true);
  FastLED.addLeds<WS2811, DATA_PIN, RGB>(leds, NUM_LEDS);
  FastLED.setBrightness(BRIGHTNESS);

}

void loop() {
  
  //yeni veri geliyor
  if (ok) {data_temp=real_data; real_data = ""; ok = false;}
  
  //veri parcalanıyor
  Serial.println(data_temp);
  led_sira = data_temp.substring(1,4).toInt();
  renk_kodu= data_temp.substring(4,5);
  renk_pwm= data_temp.substring(5,8).toInt();

 String gonder = "led_sira"+String(led_sira)+"renk_kodu"+renk_kodu+"renk pwm"+String(renk_pwm);
  Serial.println(gonder);

  leds[1] = 0xFF007F;
  FastLED.show();
}
void serialEvent(){
  while (Serial.available()){
    char temp = (char)Serial.read();
    if (temp == '\n'){ok = true;}
      real_data += temp;}
    }
