using AkilliAmbiyansRGBLED.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NAudio.CoreAudioApi;
using System.Diagnostics;//fps hesaplama

namespace AkilliAmbiyansRGBLED
{
    public partial class Form1 : Form
    {
        int genislik, yukseklik, x_bolunme, y_bolunme;
        bool ilk_calistirma = false; bool suren_islem = false; bool ilk_calistirma_music = false; bool music_suren_islem = false; bool efekt_suren_islem = false;
        bool ilk_calistirma_efekt = false; bool dinlendirme_mod = false;
        byte yatay_derinlik_deger, dikey_derinlik_deger; byte yukseltme_degeri = 0; byte music_modu_degiskeni = 255; byte efekt_modu_degiskeni = 0;
        byte saydir = 0;//sıralı music led için byte dizisini dizmek için kullanılıyor
        Stopwatch zaman_say = new Stopwatch();//uyku modu için global zaman sayma
        //diziler byte tipinde oluşturuldu
        Byte[] sayilar = new Byte[((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3];

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        //genel olarak işçiler tanımlanıyor
        Thread fps_cekirdek;
        Thread music_cekirdek;
        Thread efekt_cekirdek;
        public void baglanti_ac()
        {
            //comboBox üzerinden port seçildi butonlar açılıp timer ve comboboxlar kapatılacak
            baglan_b.Enabled = true;
            portlar.Enabled = false;
        }
        public void verigonder(Byte deger, Byte uzunluk)
        {
            if (serialPort1.IsOpen == true)
            {
                //serialPort1.Write(deger, 0, uzunluk);
            }
        }

        private void baglan_b_Click(object sender, EventArgs e)
        {
            baglan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ayarlar yükleniyor
            yatay_led.Value = Settings.Default.yatay;
            dikey_led.Value = Settings.Default.dikey;
            //çözünürlük yükleniyor
            genislik = Screen.PrimaryScreen.Bounds.Width;
            yukseklik = Screen.PrimaryScreen.Bounds.Height;
            //music ayarları

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            ortam_muzik.Items.AddRange(devices.ToArray());
        }

        private void portlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti_ac();
        }

        private void portlar_Click(object sender, EventArgs e)
        {
            if (portlar.Text == "Port Seçin")
            {
                portlar.Items.Clear();
                for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
                {
                    portlar.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
                }
            }
        }
        public void baglan()
        {//port açılıp bağlanılıyor
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = portlar.Text;
                serialPort1.BaudRate = Convert.ToInt32(haberlesme_hiz.Text);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;

                baglanti_bildirim.Text = "Bağlanılıyor...";
                try
                {
                    serialPort1.Open();
                    baglan_b.Text = "Bağlantıyı Kes";
                    periyodik_kontrol.Enabled = true;
                    baglanti_bildirim.Text = "Bağlanıldı.";

                }
                catch (Exception hata)
                {
                    periyodik_kontrol.Enabled = false;
                    baglanti_bildirim.Text = "Hata:" + hata.Message;
                    serialPort1.Close();
                    baglan_b.Text = "Bağlan";
                    baglanti_bildirim.Text = "Bağlantı Yok";
                    baglan_b.Enabled = false;
                    portlar.Enabled = true;
                    haberlesme_hiz.Enabled = true;
                    portlar.Text = "Port Seçin";
                    portlar.Items.Clear();
                }
            }
            else
            {
                serialPort1.Close();
                baglan_b.Text = "Bağlan";
                baglanti_bildirim.Text = "Bağlantı Yok";
                periyodik_kontrol.Enabled = false;
                baglan_b.Enabled = false;
                portlar.Enabled = true;
                haberlesme_hiz.Enabled = true;
                portlar.Text = "Port Seçin";
                portlar.Items.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //renk seçildi ise renk kodu byte olarak rgb olarak aktarılır pwm
                button8.BackColor = colorDialog1.Color;
                byte red = colorDialog1.Color.R;
                byte green = colorDialog1.Color.G;
                byte blue = colorDialog1.Color.B;

                //progressbar rgb pwm değerleri yansıtılıyor
                red_prog.Value = Convert.ToInt32(red);
                green_prog.Value = Convert.ToInt32(green);
                blue_prog.Value = Convert.ToInt32(blue);

                //diziler byte tipinde oluşturuldu
                Byte[] sayilar = new Byte[((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3];

                //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                {
                    sayilar[i] = red;
                    sayilar[i + 1] = green;
                    sayilar[i + 2] = blue;
                }

                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Write(sayilar, 0, sayilar.Length);
                    serialPort1.Write(sayilar, 0, sayilar.Length);
                }

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Settings.Default.dikey = Convert.ToInt32(dikey_led.Value);
            Settings.Default.yatay = Convert.ToInt32(yatay_led.Value);
            Settings.Default.Save();
        }

        private void hesaplama_buton_Click(object sender, EventArgs e)
        {
            //cozunurluk
            genislik_text.Text = genislik.ToString();
            yukseklik_text.Text = yukseklik.ToString();
            //bolunme pixel hesap
            sol_bol.Text = (yukseklik / Convert.ToInt32(dikey_led.Value)).ToString();
            ust_bol.Text = (genislik / Convert.ToInt32(yatay_led.Value)).ToString();
            alt_bol.Text = (genislik / Convert.ToInt32(yatay_led.Value)).ToString();
            sag_bol.Text = (yukseklik / Convert.ToInt32(dikey_led.Value)).ToString();
            //bolunme değişkenleri atanıyor
            y_bolunme = Convert.ToInt32(sol_bol.Text);
            x_bolunme = Convert.ToInt32(ust_bol.Text);
            //her analiz için bir analiz alanı
            sol_alan.Text = (yatay_derinlik.Value * Convert.ToInt32(sol_bol.Text)).ToString();
            sag_alan.Text = (yatay_derinlik.Value * Convert.ToInt32(sag_bol.Text)).ToString();
            alt_alan.Text = (dikey_derinlik.Value * Convert.ToInt32(alt_bol.Text)).ToString();
            ust_alan.Text = (dikey_derinlik.Value * Convert.ToInt32(ust_bol.Text)).ToString();
            //derinlik analizi için değer byte değerine aktarılıyor (daha düşük yer kaplasın diye)
            dikey_derinlik_deger = Convert.ToByte(dikey_derinlik.Value);
            yatay_derinlik_deger = Convert.ToByte(yatay_derinlik.Value);
            //çalıştır butonu aktif ediliyor hesaplamalar yapıldı
            calistir_buton.Enabled = true;

        }

        private void ortam_muzik_SelectedIndexChanged(object sender, EventArgs e)
        {
            var device = (MMDevice)ortam_muzik.SelectedItem;
            int booster = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * yukseltme.Value));
            if (booster > 100) { booster = 100; }

        }

        private void muzik_calistir_Click(object sender, EventArgs e)
        {

            if (ortam_muzik.Text == "Lütfen bir ses aygıtı seçin.")
            {
                MessageBox.Show("Lütfen bir ses aygıtı seçin.");
            }
            else
            {
                //ilk çalıştırma
                if (!ilk_calistirma_music)
                {
                    //iscilerin is parçacıkları tanıtıldı
                    music_cekirdek = new Thread(music_cekirdek_islemi);
                    //debug için işçi isimleri
                    music_cekirdek.Name = "music_iscisi";
                    //yukseltme.Value thread için değişkene atanıyor
                    yukseltme_degeri = Convert.ToByte(yukseltme.Value);
                    //music modu belirleniyor
                    switch (music_modu.Text)
                    {
                        case "Sabit Renk (Kırmızı)":
                            music_modu_degiskeni = 0;
                            break;
                        case "Sabit Renk (Mavi)":
                            music_modu_degiskeni = 1;
                            break;
                        case "Sabit Renk (Yeşil)":
                            music_modu_degiskeni = 2;
                            break;
                        case "Sabit Renk (Beyaz)":
                            music_modu_degiskeni = 3;
                            break;
                        case "Sabit Renk (Rastgele)":
                            music_modu_degiskeni = 4;
                            break;
                        case "Sırala (Kırmızı)":
                            music_modu_degiskeni = 5;
                            break;
                        case "Sırala (Yeşil)":
                            music_modu_degiskeni = 6;
                            break;
                        case "Sırala (Mavi)":
                            music_modu_degiskeni = 7;
                            break;
                        case "Sırala (Beyaz)":
                            music_modu_degiskeni = 8;
                            break;
                        case "Sırala (Rastgele)":
                            music_modu_degiskeni = 9;
                            break;
                        case "Sırala (Dağıt Şerit)":
                            music_modu_degiskeni = 10;
                            break;
                    }
                    //music çekirdek öncelikleri tanımlanıyor
                    switch (isci_music_oncelik.Text)
                    {
                        case "Düşük":
                            music_cekirdek.Priority = ThreadPriority.Lowest;
                            break;
                        case "Ekonomi":
                            music_cekirdek.Priority = ThreadPriority.BelowNormal;
                            break;
                        case "Normal":
                            music_cekirdek.Priority = ThreadPriority.Normal;

                            break;
                        case "Performans":
                            music_cekirdek.Priority = ThreadPriority.AboveNormal;

                            break;
                        case "Yüksek Performans":
                            music_cekirdek.Priority = ThreadPriority.Highest;
                            break;
                    }
                    //thread içindeki sürdürülen işlem
                    music_suren_islem = true;
                    //işçiler çalıştırılsın
                    music_cekirdek.Start();
                    //butonlar
                    isci_music_oncelik.Enabled = false;
                    music_modu.Enabled = false;
                    ortam_muzik.Enabled = false;
                    yukseltme.Enabled = false;
                    muzik_calistir.Text = "Durdur";
                    //başlat durdur için bool
                    ilk_calistirma_music = true;
                    //muzik değişkenleri oluşturuluyor
                    var device = (MMDevice)ortam_muzik.SelectedItem;
                    int booster = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * yukseltme.Value));
                    if (booster > 100) { booster = 100; }


                }
                else
                {

                    //yasıyor ise durdurulacak
                    if (music_cekirdek != null && music_cekirdek.IsAlive) { music_cekirdek.Suspend(); }
                    //thread içindeki sürdürülen işlem
                    music_suren_islem = false;
                    //buton ayarları
                    isci_music_oncelik.Enabled = true;
                    music_modu.Enabled = true;
                    ortam_muzik.Enabled = true;
                    yukseltme.Enabled = true;
                    muzik_calistir.Text = "Çalıştır";
                    //başlat durdur için bool
                    ilk_calistirma_music = false;
                }
            }
        }

        public void calistir_buton_Click(object sender, EventArgs e)
        {
            //ilk çalıştırma
            if (!ilk_calistirma)
            {
                //iscilerin is parçacıkları tanıtıldı
                fps_cekirdek = new Thread(fps_cekirdek_islemi);
                //debug için işçi isimleri
                fps_cekirdek.Name = "fps_iscisi";
                //fps çekirdek öncelikleri tanımlanıyor
                switch (fps_isci.Text)
                {
                    case "Düşük":
                        fps_cekirdek.Priority = ThreadPriority.Lowest;
                        break;
                    case "Ekonomi":
                        fps_cekirdek.Priority = ThreadPriority.BelowNormal;
                        break;
                    case "Normal":
                        fps_cekirdek.Priority = ThreadPriority.Normal;
                        break;
                    case "Performans":
                        fps_cekirdek.Priority = ThreadPriority.AboveNormal;
                        break;
                    case "Yüksek Performans":
                        fps_cekirdek.Priority = ThreadPriority.Highest;
                        break;
                }
                //thread içindeki sürdürülen işlem
                suren_islem = true;
                //işçiler çalıştırılsın
                fps_cekirdek.Start();
                //butonlar
                hesaplama_buton.Enabled = false;
                yatay_derinlik.Enabled = false;
                dikey_derinlik.Enabled = false;
                calistir_buton.Text = "Durdur";
                //başlat durdur için bool
                ilk_calistirma = true;
            }
            else
            {

                //yasıyor ise durdurulacak
                if (fps_cekirdek != null && fps_cekirdek.IsAlive) { fps_cekirdek.Suspend(); }
                //thread içindeki sürdürülen işlem
                suren_islem = false;
                //buton ayarları
                hesaplama_buton.Enabled = true;
                yatay_derinlik.Enabled = true;
                dikey_derinlik.Enabled = true;
                ilk_calistirma = false;
                calistir_buton.Text = "Çalıştır";
                MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                ortam_muzik.Items.Clear();
                ortam_muzik.Items.AddRange(devices.ToArray());
                ortam_muzik.Text = "Lütfen bir ses aygıtı seçin.";
            }
        }

        private void haberlesme_hiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            haberlesme_hiz.Enabled = false;
        }

        private void efekti_baslat_Click(object sender, EventArgs e)
        {
            if (efekt_modlari.Text == "Lütfen bir efekt seçin.")
            {
                MessageBox.Show("Lütfen bir efekt seçin.");
            }
            else
            {
                //ilk çalıştırma
                if (!ilk_calistirma_efekt)
                {
                    //iscilerin is parçacıkları tanıtıldı
                    efekt_cekirdek = new Thread(efekt_cekirdek_islemi);
                    //debug için işçi isimleri
                    efekt_cekirdek.Name = "efekt_iscisi";
                    //efekt modu belirleniyor
                    switch (efekt_modlari.Text){
                        case "Polis":
                            efekt_modu_degiskeni = 0;
                            break;
                        case "İtfaye":
                            efekt_modu_degiskeni = 1;
                            break;
                        case "Ambulans":
                            efekt_modu_degiskeni = 2;
                            break;
                        case "Sakinleştirici":
                            efekt_modu_degiskeni = 3;
                            music_modu_degiskeni = 255;
                            dinlendirme_mod = false;
                            break;
                        case "Uyku":
                            efekt_modu_degiskeni = 4;
                            zaman_say.Stop();//zaman başlatılıyor
                            zaman_say.Start();//zaman başlatılıyor
                            music_modu_degiskeni = 255;
                            break;
                        case "Flash":
                            efekt_modu_degiskeni = 5;
                            break;
                    }
                    //fps çekirdek öncelikleri tanımlanıyor
                    switch (efekt_onceligi.Text)
                    {
                        case "Düşük":
                            efekt_cekirdek.Priority = ThreadPriority.Lowest;
                            break;
                        case "Ekonomi":
                            efekt_cekirdek.Priority = ThreadPriority.BelowNormal;
                            break;
                        case "Normal":
                            efekt_cekirdek.Priority = ThreadPriority.Normal;
                            break;
                        case "Performans":
                            efekt_cekirdek.Priority = ThreadPriority.AboveNormal;
                            break;
                        case "Yüksek Performans":
                            efekt_cekirdek.Priority = ThreadPriority.Highest;
                            break;
                    }
                    //thread içindeki sürdürülen işlem
                    efekt_suren_islem = true;
                    //işçiler çalıştırılsın
                    efekt_cekirdek.Start();
                    //butonlar
                    efekti_baslat.Text = "Durdur";
                    //başlat durdur için bool
                    ilk_calistirma_efekt = true;
                }
                else
                {
                    //yasıyor ise durdurulacak
                    if (efekt_cekirdek != null && efekt_cekirdek.IsAlive) { efekt_cekirdek.Suspend(); }
                    //thread içindeki sürdürülen işlem
                    efekt_suren_islem = false;
                    //buton ayarları
                    ilk_calistirma_efekt = false;
                    efekti_baslat.Text = "Çalıştır";
                }
            }
        }

        private void efekt_modlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uyku modu seçildiğinden uyku modunun seçenepleri açılıcak
            //seçilmediğinde ise boşuna seçenekler açık olmayacak
            if (efekt_modlari.Text == "Uyku") {
                uyku_suresi.Enabled = true;
                uyku_sure_azalt.Enabled = true;
                pwm_uyku.Enabled = true;
            }else{
                uyku_suresi.Enabled = false;
                uyku_sure_azalt.Enabled = false;
                pwm_uyku.Enabled = false;
            }
        }

        private void periyodik_kontrol_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) { baglan(); }
        }

        private void fps_cekirdek_islemi()
        {
            //suren islem durdurma baslatma için bool
            while (suren_islem)
            {
                //fps hesaplama
                Stopwatch watch = new Stopwatch();
                watch.Start();
                //ekran kopyalanıyor
                Bitmap Screenshot = new Bitmap(genislik, yukseklik);
                using (Graphics GFX = Graphics.FromImage(Screenshot))
                {
                    GFX.CopyFromScreen(0, 0, 0, 0, Screenshot.Size, CopyPixelOperation.SourceCopy);
                }

                //diziler byte tipinde oluşturuldu
                Byte[] gonderilen = new Byte[((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3];

                //veri dizimi için sayaç ayarlanıyor
                int sayac_anlik = 0;

                //fonk degiskenleri tanımlanıyor
                int alan = 0;
                int red = 0;
                int green = 0;
                int blue = 0;

                //pixel analizi yapılacak resim using kullanılarak seçilip ram tasarrufu yapılıyor
                using (Bitmap myBitmap = new Bitmap(Screenshot))
                {
                    //dikey soldan sağa pixel alanları gönderiliyor
                    for (int i = 0; i <= (genislik - x_bolunme); i += x_bolunme)
                    {

                        //ilk degiskenler sifirlanıyor ve dikey soldan sağa pixel alanları gönderiliyor
                        alan = ((i + x_bolunme) - i) * (dikey_derinlik_deger);
                        red = 0;
                        green = 0;
                        blue = 0;

                        for (int c = 1; c <= dikey_derinlik_deger; c++)
                        {
                            for (int b = i; b <= (i + x_bolunme - 1); b++)
                            {
                                Color pixelColor = myBitmap.GetPixel(b, c);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                            }
                        }
                        red /= alan;
                        green /= alan;
                        blue /= alan;

                        gonderilen[sayac_anlik] = Convert.ToByte(red);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(green);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(blue);
                        sayac_anlik++;
                    }
                    //dikey aşağıya pixseller taranıyor
                    for (int i = 0; i <= (yukseklik - y_bolunme); i += y_bolunme)
                    {

                        //ilk degiskenler sifirlanıyor ve dikey aşağıya pixseller taranıyor
                        alan = ((genislik) - (genislik - yatay_derinlik_deger)) * ((i + y_bolunme) - i);
                        red = 0;
                        green = 0;
                        blue = 0;

                        for (int c = i; c <= (i + y_bolunme - 1); c++)
                        {
                            for (int b = (genislik - yatay_derinlik_deger); b <= (genislik - 1); b++)
                            {
                                Color pixelColor = myBitmap.GetPixel(b, c);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                            }
                        }
                        red /= alan;
                        green /= alan;
                        blue /= alan;

                        gonderilen[sayac_anlik] = Convert.ToByte(red);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(green);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(blue);
                        sayac_anlik++;
                    }
                    //sağ alttan sola doğru yatay ilerliyor aşağıdaki pixseller taranıyor
                    for (int i = 1920; i >= 5; i -= x_bolunme)
                    {

                        //ilk degiskenler sifirlanıyor sağ alttan sola doğru yatay ilerliyor aşağıdaki pixseller taranıyor
                        alan = ((i) - (i - x_bolunme)) * ((yukseklik) - (yukseklik - dikey_derinlik_deger));
                        red = 0;
                        green = 0;
                        blue = 0;

                        for (int c = (yukseklik - dikey_derinlik_deger); c <= (yukseklik - 1); c++)
                        {
                            for (int b = (i - x_bolunme); b <= (i - 1); b++)
                            {
                                Color pixelColor = myBitmap.GetPixel(b, c);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                            }
                        }
                        red /= alan;
                        green /= alan;
                        blue /= alan;

                        gonderilen[sayac_anlik] = Convert.ToByte(red);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(green);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(blue);
                        sayac_anlik++;
                    }
                    //dikey yukarı pixseller taranıyor
                    for (int i = 1080; i >= 5; i -= y_bolunme)
                    {

                        //ilk degiskenler sifirlanıyor ve dikey yukarı pixseller taranıyor
                        alan = ((yatay_derinlik_deger + 1)) * ((i) - (i - y_bolunme));
                        red = 0;
                        green = 0;
                        blue = 0;

                        for (int c = (i - y_bolunme); c <= (i - 1); c++)
                        {
                            for (int b = 1; b <= (yatay_derinlik_deger + 1); b++)
                            {
                                Color pixelColor = myBitmap.GetPixel(b, c);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                            }
                        }
                        red /= alan;
                        green /= alan;
                        blue /= alan;

                        gonderilen[sayac_anlik] = Convert.ToByte(red);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(green);
                        sayac_anlik++;
                        gonderilen[sayac_anlik] = Convert.ToByte(blue);
                        sayac_anlik++;
                    }
                    //resim ram den siliniyor
                    if (myBitmap != null) { myBitmap.Dispose(); GC.Collect(); }
                    if (serialPort1.IsOpen == true) { serialPort1.Write(gonderilen, 0, gonderilen.Length); }
                    watch.Stop();
                    fps_degeri.Text = watch.Elapsed.Milliseconds.ToString();
                }
            }
        }
        private void music_cekirdek_islemi()
        {
            //while  ile sürekli işlem kılıyoruz
            while (music_suren_islem)
            {
                try
                {
                    //fps hesaplama
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    var device = (MMDevice)ortam_muzik.SelectedItem;
                    int booster = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * yukseltme_degeri));
                    if (booster > 100) { booster = 100; }
                    byte music_pwm = Convert.ToByte((booster * 255) / 100);


                    if (muzik_seviye_goster.Checked == true) { ortam_music_seviyesi.Value = booster; }
                    //music modu belirleniyor
                    switch (music_modu_degiskeni)
                    {
                        case 0:
                            //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = music_pwm;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Write(sayilar, 0, sayilar.Length);
                            }
                            break;
                        case 1:
                            //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = music_pwm;
                            }
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Write(sayilar, 0, sayilar.Length);
                            }
                            break;
                        case 2:
                            music_modu_degiskeni = 2;
                            //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = music_pwm;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Write(sayilar, 0, sayilar.Length);
                            }
                            break;
                        case 3:
                            //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = music_pwm;
                                sayilar[i + 1] = music_pwm;
                                sayilar[i + 2] = music_pwm;
                            }
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Write(sayilar, 0, sayilar.Length);
                            }
                            break;
                        case 4:
                            music_modu_degiskeni = 4;

                            //rastgele deger çekiliyor true false için
                            Random rastgele = new Random();
                            int sayi = rastgele.Next(0, 10);

                            //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {

                                if (sayi < 5) { sayilar[i] = music_pwm; } else { sayilar[i] = 0; }
                                sayi = rastgele.Next(0, 10);
                                if (sayi < 5) { sayilar[i + 1] = music_pwm; } else { sayilar[i + 1] = 0; }
                                sayi = rastgele.Next(0, 10);
                                if (sayi < 5) { sayilar[i + 2] = music_pwm; } else { sayilar[i + 2] = 0; }
                            }
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Write(sayilar, 0, sayilar.Length);
                            }
                            break;
                        case 5:
                            //ledler sıralı gidicek. kırmızı
                            music_modu_degiskeni = 5;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }
                            sayilar[0] = music_pwm;
                            sayilar[1] = 0;
                            sayilar[2] = 0;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }

                            break;
                        case 6:
                            //ledler sıralı gidicek.yeşil
                            music_modu_degiskeni = 6;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }
                            sayilar[0] = 0;
                            sayilar[1] = music_pwm;
                            sayilar[2] = 0;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }

                            break;
                        case 7:
                            //ledler sıralı gidicek.mavi
                            music_modu_degiskeni = 7;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }
                            sayilar[0] = 0;
                            sayilar[1] = 0;
                            sayilar[2] = music_pwm;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }

                            break;
                        case 8:
                            //ledler sıralı gidicek. beyaz
                            music_modu_degiskeni = 8;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }
                            sayilar[0] = music_pwm;
                            sayilar[1] = music_pwm;
                            sayilar[2] = music_pwm;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                             
                            break;
                        case 9:
                            //ledler sıralı gidicek. rastgele
                            music_modu_degiskeni = 9;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }
                            //rastgele deger çekiliyor true false için
                            rastgele = new Random();
                            sayi = rastgele.Next(0, 10);

                            if (sayi < 5) { sayilar[0] = music_pwm; } else { sayilar[0] = 0; }
                            sayi = rastgele.Next(0, 10);
                            if (sayi < 5) { sayilar[1] = music_pwm; } else { sayilar[1] = 0; }
                            sayi = rastgele.Next(0, 10);
                            if (sayi < 5) { sayilar[2] = music_pwm; } else { sayilar[2] = 0; }

                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }

                            break;
                        case 10:
                            //ledler sıralı gidicek. rastgele renklersıralı gönderilecek
                            music_modu_degiskeni = 10;
                            for (int i = sayilar.Length - 6; i >= 0; i -= 3)
                            {
                                sayilar[i + 5] = sayilar[i + 2];
                                sayilar[i + 4] = sayilar[i + 1];
                                sayilar[i + 3] = sayilar[i];
                            }

                            //if (saydir<10) { sayilar[0] = music_pwm; saydir++;  } else { sayilar[0] = 0; }
                            //if (saydir < 20 && saydir>10) { sayilar[1] = music_pwm; saydir++; } else { sayilar[1] = 0; }
                            //if (saydir < 30 && saydir>20) { sayilar[2] = music_pwm;  saydir++; } else { sayilar[2] = 0; }
                            //if(saydir > 29) { saydir = 0; }

                            if (saydir < 10 && saydir >= 0) { sayilar[0] = music_pwm; saydir++; } else { sayilar[0] = 0; saydir++; }
                            if (saydir > 10 && saydir < 20) { sayilar[1] = music_pwm; saydir++; } else { sayilar[1] = 0; saydir++; }
                            if (saydir > 20 && saydir < 30) { sayilar[2] = music_pwm; saydir++; } else { sayilar[2] = 0; saydir++; }
                            if (saydir > 29) { saydir = 0; }
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }

                            break;
                    }
                    watch.Stop();
                    fps_degeri.Text = watch.Elapsed.Milliseconds.ToString();
                }
                catch { }
            }
        }
        private void efekt_cekirdek_islemi()
        {
            //while  ile sürekli işlem kılıyoruz
            while (efekt_suren_islem){
                //try{
                    //fps hesaplama
                    Stopwatch watch = new Stopwatch();
                    watch.Start();

                    switch (efekt_modu_degiskeni){
                    case 0:
                        efekt_modu_degiskeni = 0;
                        if (dinlendirme_mod)
                        { //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 255;
                            }
                        }
                        else
                        { //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 255;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                        }



                        if (dinlendirme_mod)
                        {
                            dinlendirme_mod = false; //oluşturulan bytelar gönderiliyor
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(100);
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(150);
                        }
                        else
                        {
                            dinlendirme_mod = true;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(100);
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(150);
                        }

                        break;
                    case 1:
                        efekt_modu_degiskeni = 1;
                        if (dinlendirme_mod)
                        { //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 255;
                                sayilar[i + 1] = 255;
                                sayilar[i + 2] = 255;
                            }
                        } else{ //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 255;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                        }

                        

                        if (dinlendirme_mod){
                            dinlendirme_mod = false; //oluşturulan bytelar gönderiliyor
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(100);
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(150);
                        }
                        else{
                            dinlendirme_mod = true;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(100);
                            for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3)
                            {
                                sayilar[i] = 0;
                                sayilar[i + 1] = 0;
                                sayilar[i + 2] = 0;
                            }
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(150);
                        }

                        break;
                    case 2:
                        efekt_modu_degiskeni = 2;
                        if (dinlendirme_mod) { music_modu_degiskeni = 255; } else { music_modu_degiskeni = 0; }
                        //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                        for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3){
                            sayilar[i] = 0;
                            sayilar[i + 1] = 0;
                            sayilar[i + 2] = music_modu_degiskeni;
                        }

                        if (dinlendirme_mod) { dinlendirme_mod = false; //oluşturulan bytelar gönderiliyor
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(50);
                        }else{
                            dinlendirme_mod =true;
                            if (serialPort1.IsOpen == true) { serialPort1.Write(sayilar, 0, sayilar.Length); }
                            Thread.Sleep(100);
                        }
                        
                        break;
                    case 3:
                        efekt_modu_degiskeni = 3;
                        //dinlendirici mod

                        if (music_modu_degiskeni <= 0){
                            dinlendirme_mod = true;
                        }
                        if (music_modu_degiskeni >= 255) {
                            dinlendirme_mod = false;
                        }
                        if (dinlendirme_mod){
                            music_modu_degiskeni += 1;
                        }else { music_modu_degiskeni -= 1; }

                        //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                        for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3){
                            sayilar[i] = music_modu_degiskeni;
                            sayilar[i + 1] = music_modu_degiskeni;
                            sayilar[i + 2] = music_modu_degiskeni;
                        }

                        pwm_uyku.Value = music_modu_degiskeni;
                        //oluşturulan bytelar gönderiliyor
                        if (serialPort1.IsOpen == true){serialPort1.Write(sayilar, 0, sayilar.Length);}
                        break;
                        case 4:
                            efekt_modu_degiskeni = 4;
                            //zaman bitene kadar

                            if (zaman_say.Elapsed.TotalMinutes < Convert.ToInt32(uyku_suresi.Value)) {
                                //global bir değişken pwm olarak atanacak (music_modu_degiskeni = 255; case bölümüne yazıldı)
                                //bu modda müzik modu kullanılmadığı için müzik değişkeninini kullanıcağız (ram tasarrufu için)
                                kalan_dk.Text = (Convert.ToInt32(uyku_suresi.Value) - zaman_say.Elapsed.TotalMinutes).ToString("0.###");
                                    if (uyku_sure_azalt.Checked == true) {
                                    //oran orantı ile sn hesapları ile gereken pwm bulunuyor
                                    music_modu_degiskeni = Convert.ToByte((((Convert.ToInt32(uyku_suresi.Value)*60) - zaman_say.Elapsed.TotalSeconds)*255)/ (Convert.ToInt32(uyku_suresi.Value) * 60));

                                    }else { music_modu_degiskeni = 255; }
                                    //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                                    for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3){
                                        sayilar[i] = music_modu_degiskeni;
                                        sayilar[i + 1] = music_modu_degiskeni;
                                        sayilar[i + 2] = music_modu_degiskeni;
                                    }
                                    pwm_uyku.Value = music_modu_degiskeni;
                                    //oluşturulan bytelar gönderiliyor
                                    if (serialPort1.IsOpen == true){
                                            serialPort1.Write(sayilar, 0, sayilar.Length);
                                    }
                            }
                            else{
                                kalan_dk.Text ="dk bitti.";
                                //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                                for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3){
                                    sayilar[i] = 0;
                                    sayilar[i + 1] = 0;
                                    sayilar[i + 2] = 0;
                                }
                                pwm_uyku.Value = music_modu_degiskeni;
                                //oluşturulan bytelar gönderiliyor
                                if (serialPort1.IsOpen == true){
                                    serialPort1.Write(sayilar, 0, sayilar.Length);
                                }
                            }
                            break;
                        case 5:
                            efekt_modu_degiskeni = 5;
                            byte gecici_pwm = 0;//ilk pwm
                            byte bekleme = 5;//ilk bekleme süresi
                            //do while ile sürekli dönen 2 farklı işlemi tek işleme düşürdük
                            do{
                                //diziye rgb pwm değerleri byte cinsinden aktarılıyor
                                for (int i = 0; i < ((Settings.Default.dikey * 2) + (Settings.Default.yatay * 2)) * 3; i = i + 3){
                                    sayilar[i] = gecici_pwm;
                                    sayilar[i + 1] = gecici_pwm;
                                    sayilar[i + 2] = gecici_pwm;
                                }
                                //oluşturulan bytelar gönderiliyor
                                if (serialPort1.IsOpen == true){
                                    serialPort1.Write(sayilar, 0, sayilar.Length);
                                }
                                //yeni flash göndermeden önce bekleme süresi
                                Thread.Sleep(bekleme);
                                //bekleme ile aynı zamanda do while kontrol ediliyor ikinci döngüden sonra bekleme arttırılıp
                                //do whileden çıkması sağlanıyor
                                if (bekleme > 19) { bekleme = 200; } else{
                                    gecici_pwm = 255;//ikinci pwm
                                    bekleme = 20;//ikinci bekleme süresi
                                }
                            } while (bekleme < 199);
                            break;
                    }
                    watch.Stop();// fps hesaplama için watch durduruluyor
                    fps_degeri.Text = watch.Elapsed.Milliseconds.ToString(); //saniyedeki döngü sayısının ms cinsinden 1000ms bölüp fps (frame per second) buluyoruz
                //}catch { }

            }
        }

    }
}
