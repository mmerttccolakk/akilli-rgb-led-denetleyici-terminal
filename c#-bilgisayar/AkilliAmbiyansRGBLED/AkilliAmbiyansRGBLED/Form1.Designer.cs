namespace AkilliAmbiyansRGBLED
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baglanti_bildirim = new System.Windows.Forms.Label();
            this.baglan_b = new System.Windows.Forms.Button();
            this.haberlesme_hiz = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.portlar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.anlik_goruntu = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yatay_led = new System.Windows.Forms.NumericUpDown();
            this.dikey_led = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fps_isci = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kalan_dk = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fps_degeri = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.blue_prog = new System.Windows.Forms.ProgressBar();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.red_prog = new System.Windows.Forms.ProgressBar();
            this.green_prog = new System.Windows.Forms.ProgressBar();
            this.button11 = new System.Windows.Forms.Button();
            this.cekirdek_onemi = new System.Windows.Forms.TabPage();
            this.calistir_buton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sol_alan = new System.Windows.Forms.Label();
            this.sag_alan = new System.Windows.Forms.Label();
            this.alt_alan = new System.Windows.Forms.Label();
            this.ust_alan = new System.Windows.Forms.Label();
            this.hesaplama_buton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dikey_derinlik = new System.Windows.Forms.TrackBar();
            this.yatay_derinlik = new System.Windows.Forms.TrackBar();
            this.sol_bol = new System.Windows.Forms.Label();
            this.sag_bol = new System.Windows.Forms.Label();
            this.alt_bol = new System.Windows.Forms.Label();
            this.ust_bol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yukseklik_text = new System.Windows.Forms.Label();
            this.genislik_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.muzik_seviye_goster = new System.Windows.Forms.CheckBox();
            this.ortam_music_seviyesi = new System.Windows.Forms.ProgressBar();
            this.music_modu = new System.Windows.Forms.ComboBox();
            this.isci_music_oncelik = new System.Windows.Forms.ComboBox();
            this.muzik_calistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yukseltme = new System.Windows.Forms.TrackBar();
            this.ortam_muzik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pwm_uyku = new System.Windows.Forms.ProgressBar();
            this.uyku_sure_azalt = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uyku_suresi = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.efekt_modlari = new System.Windows.Forms.ComboBox();
            this.efekti_baslat = new System.Windows.Forms.Button();
            this.efekt_onceligi = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.periyodik_kontrol = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anlik_goruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yatay_led)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dikey_led)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cekirdek_onemi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dikey_derinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yatay_derinlik)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukseltme)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyku_suresi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baglanti_bildirim);
            this.groupBox1.Controls.Add(this.baglan_b);
            this.groupBox1.Controls.Add(this.haberlesme_hiz);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.portlar);
            this.groupBox1.Location = new System.Drawing.Point(580, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Ayarları";
            // 
            // baglanti_bildirim
            // 
            this.baglanti_bildirim.AutoSize = true;
            this.baglanti_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglanti_bildirim.Location = new System.Drawing.Point(48, 131);
            this.baglanti_bildirim.Name = "baglanti_bildirim";
            this.baglanti_bildirim.Size = new System.Drawing.Size(111, 20);
            this.baglanti_bildirim.TabIndex = 11;
            this.baglanti_bildirim.Text = "Bağlantı Yok";
            // 
            // baglan_b
            // 
            this.baglan_b.Enabled = false;
            this.baglan_b.Location = new System.Drawing.Point(7, 91);
            this.baglan_b.Name = "baglan_b";
            this.baglan_b.Size = new System.Drawing.Size(195, 23);
            this.baglan_b.TabIndex = 10;
            this.baglan_b.Text = "Bağlan";
            this.baglan_b.UseVisualStyleBackColor = true;
            this.baglan_b.Click += new System.EventHandler(this.baglan_b_Click);
            // 
            // haberlesme_hiz
            // 
            this.haberlesme_hiz.FormattingEnabled = true;
            this.haberlesme_hiz.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.haberlesme_hiz.Location = new System.Drawing.Point(95, 56);
            this.haberlesme_hiz.Name = "haberlesme_hiz";
            this.haberlesme_hiz.Size = new System.Drawing.Size(107, 21);
            this.haberlesme_hiz.TabIndex = 9;
            this.haberlesme_hiz.Text = "115200";
            this.haberlesme_hiz.SelectedIndexChanged += new System.EventHandler(this.haberlesme_hiz_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Baund Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Port";
            // 
            // portlar
            // 
            this.portlar.FormattingEnabled = true;
            this.portlar.Location = new System.Drawing.Point(95, 29);
            this.portlar.Name = "portlar";
            this.portlar.Size = new System.Drawing.Size(107, 21);
            this.portlar.TabIndex = 6;
            this.portlar.Text = "Port Seçin";
            this.portlar.SelectedIndexChanged += new System.EventHandler(this.portlar_SelectedIndexChanged);
            this.portlar.Click += new System.EventHandler(this.portlar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.anlik_goruntu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.yatay_led);
            this.groupBox2.Controls.Add(this.dikey_led);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED ve Ekran Ayarları";
            // 
            // anlik_goruntu
            // 
            this.anlik_goruntu.Image = ((System.Drawing.Image)(resources.GetObject("anlik_goruntu.Image")));
            this.anlik_goruntu.Location = new System.Drawing.Point(28, 32);
            this.anlik_goruntu.Name = "anlik_goruntu";
            this.anlik_goruntu.Size = new System.Drawing.Size(267, 144);
            this.anlik_goruntu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anlik_goruntu.TabIndex = 19;
            this.anlik_goruntu.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(327, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Led Bağlantılarını soldan sağa doğru kurunuz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayarları Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(327, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dikey LED sayisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yatay LED Sayısı";
            // 
            // yatay_led
            // 
            this.yatay_led.Location = new System.Drawing.Point(445, 18);
            this.yatay_led.Name = "yatay_led";
            this.yatay_led.Size = new System.Drawing.Size(109, 20);
            this.yatay_led.TabIndex = 2;
            // 
            // dikey_led
            // 
            this.dikey_led.Location = new System.Drawing.Point(445, 59);
            this.dikey_led.Name = "dikey_led";
            this.dikey_led.Size = new System.Drawing.Size(109, 20);
            this.dikey_led.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fps_isci
            // 
            this.fps_isci.FormattingEnabled = true;
            this.fps_isci.Items.AddRange(new object[] {
            "Düşük",
            "Ekonomi",
            "Normal",
            "Performans",
            "Yüksek Performans"});
            this.fps_isci.Location = new System.Drawing.Point(397, 54);
            this.fps_isci.Name = "fps_isci";
            this.fps_isci.Size = new System.Drawing.Size(139, 21);
            this.fps_isci.TabIndex = 22;
            this.fps_isci.Text = "Yüksek Performans";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kalan_dk);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.fps_degeri);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İstatislik-Durum";
            // 
            // kalan_dk
            // 
            this.kalan_dk.AutoSize = true;
            this.kalan_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_dk.Location = new System.Drawing.Point(93, 52);
            this.kalan_dk.Name = "kalan_dk";
            this.kalan_dk.Size = new System.Drawing.Size(18, 20);
            this.kalan_dk.TabIndex = 24;
            this.kalan_dk.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 18);
            this.label18.TabIndex = 23;
            this.label18.Text = "Kalan (dk):";
            // 
            // fps_degeri
            // 
            this.fps_degeri.AutoSize = true;
            this.fps_degeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fps_degeri.Location = new System.Drawing.Point(57, 23);
            this.fps_degeri.Name = "fps_degeri";
            this.fps_degeri.Size = new System.Drawing.Size(18, 20);
            this.fps_degeri.TabIndex = 21;
            this.fps_degeri.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "FPS:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(219, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(569, 179);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modlar";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.cekirdek_onemi);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 154);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.blue_prog);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.red_prog);
            this.tabPage1.Controls.Add(this.green_prog);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(548, 128);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Sabit Renk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(23, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 23);
            this.button9.TabIndex = 22;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // blue_prog
            // 
            this.blue_prog.Location = new System.Drawing.Point(60, 78);
            this.blue_prog.Maximum = 255;
            this.blue_prog.Name = "blue_prog";
            this.blue_prog.Size = new System.Drawing.Size(207, 23);
            this.blue_prog.TabIndex = 21;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(312, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 80);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(23, 50);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 23);
            this.button10.TabIndex = 20;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // red_prog
            // 
            this.red_prog.Location = new System.Drawing.Point(60, 21);
            this.red_prog.Maximum = 255;
            this.red_prog.Name = "red_prog";
            this.red_prog.Size = new System.Drawing.Size(207, 23);
            this.red_prog.TabIndex = 17;
            // 
            // green_prog
            // 
            this.green_prog.Location = new System.Drawing.Point(60, 50);
            this.green_prog.Maximum = 255;
            this.green_prog.Name = "green_prog";
            this.green_prog.Size = new System.Drawing.Size(207, 23);
            this.green_prog.TabIndex = 19;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(23, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 23);
            this.button11.TabIndex = 18;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // cekirdek_onemi
            // 
            this.cekirdek_onemi.Controls.Add(this.calistir_buton);
            this.cekirdek_onemi.Controls.Add(this.label10);
            this.cekirdek_onemi.Controls.Add(this.sol_alan);
            this.cekirdek_onemi.Controls.Add(this.fps_isci);
            this.cekirdek_onemi.Controls.Add(this.sag_alan);
            this.cekirdek_onemi.Controls.Add(this.alt_alan);
            this.cekirdek_onemi.Controls.Add(this.ust_alan);
            this.cekirdek_onemi.Controls.Add(this.hesaplama_buton);
            this.cekirdek_onemi.Controls.Add(this.label16);
            this.cekirdek_onemi.Controls.Add(this.label15);
            this.cekirdek_onemi.Controls.Add(this.label14);
            this.cekirdek_onemi.Controls.Add(this.dikey_derinlik);
            this.cekirdek_onemi.Controls.Add(this.yatay_derinlik);
            this.cekirdek_onemi.Controls.Add(this.sol_bol);
            this.cekirdek_onemi.Controls.Add(this.sag_bol);
            this.cekirdek_onemi.Controls.Add(this.alt_bol);
            this.cekirdek_onemi.Controls.Add(this.ust_bol);
            this.cekirdek_onemi.Controls.Add(this.label6);
            this.cekirdek_onemi.Controls.Add(this.yukseklik_text);
            this.cekirdek_onemi.Controls.Add(this.genislik_text);
            this.cekirdek_onemi.Controls.Add(this.label1);
            this.cekirdek_onemi.Location = new System.Drawing.Point(4, 4);
            this.cekirdek_onemi.Name = "cekirdek_onemi";
            this.cekirdek_onemi.Size = new System.Drawing.Size(548, 128);
            this.cekirdek_onemi.TabIndex = 0;
            this.cekirdek_onemi.Text = "Ambiyans";
            this.cekirdek_onemi.UseVisualStyleBackColor = true;
            // 
            // calistir_buton
            // 
            this.calistir_buton.Enabled = false;
            this.calistir_buton.Location = new System.Drawing.Point(397, 94);
            this.calistir_buton.Name = "calistir_buton";
            this.calistir_buton.Size = new System.Drawing.Size(139, 23);
            this.calistir_buton.TabIndex = 21;
            this.calistir_buton.Text = "Çalıştır";
            this.calistir_buton.UseVisualStyleBackColor = true;
            this.calistir_buton.Click += new System.EventHandler(this.calistir_buton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Pixel Analiz Alanı";
            // 
            // sol_alan
            // 
            this.sol_alan.AutoSize = true;
            this.sol_alan.Location = new System.Drawing.Point(55, 105);
            this.sol_alan.Name = "sol_alan";
            this.sol_alan.Size = new System.Drawing.Size(20, 13);
            this.sol_alan.TabIndex = 19;
            this.sol_alan.Text = "sol";
            // 
            // sag_alan
            // 
            this.sag_alan.AutoSize = true;
            this.sag_alan.Location = new System.Drawing.Point(103, 105);
            this.sag_alan.Name = "sag_alan";
            this.sag_alan.Size = new System.Drawing.Size(24, 13);
            this.sag_alan.TabIndex = 18;
            this.sag_alan.Text = "sag";
            // 
            // alt_alan
            // 
            this.alt_alan.AutoSize = true;
            this.alt_alan.Location = new System.Drawing.Point(149, 105);
            this.alt_alan.Name = "alt_alan";
            this.alt_alan.Size = new System.Drawing.Size(18, 13);
            this.alt_alan.TabIndex = 17;
            this.alt_alan.Text = "alt";
            // 
            // ust_alan
            // 
            this.ust_alan.AutoSize = true;
            this.ust_alan.Location = new System.Drawing.Point(15, 105);
            this.ust_alan.Name = "ust_alan";
            this.ust_alan.Size = new System.Drawing.Size(21, 13);
            this.ust_alan.TabIndex = 16;
            this.ust_alan.Text = "ust";
            // 
            // hesaplama_buton
            // 
            this.hesaplama_buton.Location = new System.Drawing.Point(397, 12);
            this.hesaplama_buton.Name = "hesaplama_buton";
            this.hesaplama_buton.Size = new System.Drawing.Size(139, 23);
            this.hesaplama_buton.TabIndex = 15;
            this.hesaplama_buton.Text = "Hesapla";
            this.hesaplama_buton.UseVisualStyleBackColor = true;
            this.hesaplama_buton.Click += new System.EventHandler(this.hesaplama_buton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(199, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Dikey Derinlik Analizi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(199, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Yatay Derinlik Analizi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(11, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Her Eksen İçin Pixel Sayısı";
            // 
            // dikey_derinlik
            // 
            this.dikey_derinlik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dikey_derinlik.LargeChange = 10;
            this.dikey_derinlik.Location = new System.Drawing.Point(202, 76);
            this.dikey_derinlik.Maximum = 100;
            this.dikey_derinlik.Minimum = 5;
            this.dikey_derinlik.Name = "dikey_derinlik";
            this.dikey_derinlik.Size = new System.Drawing.Size(188, 45);
            this.dikey_derinlik.TabIndex = 11;
            this.dikey_derinlik.TickFrequency = 5;
            this.dikey_derinlik.Value = 5;
            // 
            // yatay_derinlik
            // 
            this.yatay_derinlik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yatay_derinlik.LargeChange = 10;
            this.yatay_derinlik.Location = new System.Drawing.Point(202, 25);
            this.yatay_derinlik.Maximum = 100;
            this.yatay_derinlik.Minimum = 5;
            this.yatay_derinlik.Name = "yatay_derinlik";
            this.yatay_derinlik.Size = new System.Drawing.Size(188, 45);
            this.yatay_derinlik.TabIndex = 10;
            this.yatay_derinlik.TickFrequency = 5;
            this.yatay_derinlik.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.yatay_derinlik.Value = 5;
            // 
            // sol_bol
            // 
            this.sol_bol.AutoSize = true;
            this.sol_bol.Location = new System.Drawing.Point(55, 62);
            this.sol_bol.Name = "sol_bol";
            this.sol_bol.Size = new System.Drawing.Size(20, 13);
            this.sol_bol.TabIndex = 8;
            this.sol_bol.Text = "sol";
            // 
            // sag_bol
            // 
            this.sag_bol.AutoSize = true;
            this.sag_bol.Location = new System.Drawing.Point(103, 62);
            this.sag_bol.Name = "sag_bol";
            this.sag_bol.Size = new System.Drawing.Size(24, 13);
            this.sag_bol.TabIndex = 7;
            this.sag_bol.Text = "sag";
            // 
            // alt_bol
            // 
            this.alt_bol.AutoSize = true;
            this.alt_bol.Location = new System.Drawing.Point(149, 62);
            this.alt_bol.Name = "alt_bol";
            this.alt_bol.Size = new System.Drawing.Size(18, 13);
            this.alt_bol.TabIndex = 6;
            this.alt_bol.Text = "alt";
            // 
            // ust_bol
            // 
            this.ust_bol.AutoSize = true;
            this.ust_bol.Location = new System.Drawing.Point(15, 62);
            this.ust_bol.Name = "ust_bol";
            this.ust_bol.Size = new System.Drawing.Size(21, 13);
            this.ust_bol.TabIndex = 5;
            this.ust_bol.Text = "ust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "x";
            // 
            // yukseklik_text
            // 
            this.yukseklik_text.AutoSize = true;
            this.yukseklik_text.Location = new System.Drawing.Point(154, 12);
            this.yukseklik_text.Name = "yukseklik_text";
            this.yukseklik_text.Size = new System.Drawing.Size(13, 13);
            this.yukseklik_text.TabIndex = 3;
            this.yukseklik_text.Text = "0";
            // 
            // genislik_text
            // 
            this.genislik_text.AutoSize = true;
            this.genislik_text.Location = new System.Drawing.Point(103, 11);
            this.genislik_text.Name = "genislik_text";
            this.genislik_text.Size = new System.Drawing.Size(13, 13);
            this.genislik_text.TabIndex = 2;
            this.genislik_text.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çözünürlük:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.muzik_seviye_goster);
            this.tabPage2.Controls.Add(this.ortam_music_seviyesi);
            this.tabPage2.Controls.Add(this.music_modu);
            this.tabPage2.Controls.Add(this.isci_music_oncelik);
            this.tabPage2.Controls.Add(this.muzik_calistir);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.yukseltme);
            this.tabPage2.Controls.Add(this.ortam_muzik);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(548, 128);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Müzik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // muzik_seviye_goster
            // 
            this.muzik_seviye_goster.AutoSize = true;
            this.muzik_seviye_goster.Checked = true;
            this.muzik_seviye_goster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.muzik_seviye_goster.Location = new System.Drawing.Point(6, 99);
            this.muzik_seviye_goster.Name = "muzik_seviye_goster";
            this.muzik_seviye_goster.Size = new System.Drawing.Size(107, 17);
            this.muzik_seviye_goster.TabIndex = 26;
            this.muzik_seviye_goster.Text = "Seviyesini Göster";
            this.muzik_seviye_goster.UseVisualStyleBackColor = true;
            // 
            // ortam_music_seviyesi
            // 
            this.ortam_music_seviyesi.Location = new System.Drawing.Point(119, 93);
            this.ortam_music_seviyesi.Maximum = 255;
            this.ortam_music_seviyesi.Name = "ortam_music_seviyesi";
            this.ortam_music_seviyesi.Size = new System.Drawing.Size(215, 26);
            this.ortam_music_seviyesi.TabIndex = 25;
            // 
            // music_modu
            // 
            this.music_modu.FormattingEnabled = true;
            this.music_modu.Items.AddRange(new object[] {
            "Sabit Renk (Kırmızı)",
            "Sabit Renk (Mavi)",
            "Sabit Renk (Yeşil)",
            "Sabit Renk (Beyaz)",
            "Sabit Renk (Rastgele)",
            "Sırala (Kırmızı)",
            "Sırala (Yeşil)",
            "Sırala (Mavi)",
            "Sırala (Beyaz)",
            "Sırala (Rastgele)",
            "Sırala (Dağıt Şerit)"});
            this.music_modu.Location = new System.Drawing.Point(348, 50);
            this.music_modu.Name = "music_modu";
            this.music_modu.Size = new System.Drawing.Size(193, 21);
            this.music_modu.TabIndex = 24;
            this.music_modu.Text = "Sabit Renk (Kırmızı)";
            // 
            // isci_music_oncelik
            // 
            this.isci_music_oncelik.FormattingEnabled = true;
            this.isci_music_oncelik.Items.AddRange(new object[] {
            "Düşük",
            "Ekonomi",
            "Normal",
            "Performans",
            "Yüksek Performans"});
            this.isci_music_oncelik.Location = new System.Drawing.Point(350, 14);
            this.isci_music_oncelik.Name = "isci_music_oncelik";
            this.isci_music_oncelik.Size = new System.Drawing.Size(191, 21);
            this.isci_music_oncelik.TabIndex = 23;
            this.isci_music_oncelik.Text = "Yüksek Performans";
            // 
            // muzik_calistir
            // 
            this.muzik_calistir.Location = new System.Drawing.Point(350, 93);
            this.muzik_calistir.Name = "muzik_calistir";
            this.muzik_calistir.Size = new System.Drawing.Size(193, 26);
            this.muzik_calistir.TabIndex = 13;
            this.muzik_calistir.Text = "Başlat";
            this.muzik_calistir.UseVisualStyleBackColor = true;
            this.muzik_calistir.Click += new System.EventHandler(this.muzik_calistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yükselt";
            // 
            // yukseltme
            // 
            this.yukseltme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yukseltme.LargeChange = 10;
            this.yukseltme.Location = new System.Drawing.Point(6, 55);
            this.yukseltme.Maximum = 140;
            this.yukseltme.Minimum = 80;
            this.yukseltme.Name = "yukseltme";
            this.yukseltme.Size = new System.Drawing.Size(328, 45);
            this.yukseltme.TabIndex = 11;
            this.yukseltme.TickFrequency = 5;
            this.yukseltme.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.yukseltme.Value = 100;
            // 
            // ortam_muzik
            // 
            this.ortam_muzik.FormattingEnabled = true;
            this.ortam_muzik.Location = new System.Drawing.Point(64, 14);
            this.ortam_muzik.Name = "ortam_muzik";
            this.ortam_muzik.Size = new System.Drawing.Size(270, 21);
            this.ortam_muzik.TabIndex = 2;
            this.ortam_muzik.Text = "Lütfen bir ses aygıtı seçin.";
            this.ortam_muzik.SelectedIndexChanged += new System.EventHandler(this.ortam_muzik_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ortam";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pwm_uyku);
            this.tabPage4.Controls.Add(this.uyku_sure_azalt);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.uyku_suresi);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.efekt_modlari);
            this.tabPage4.Controls.Add(this.efekti_baslat);
            this.tabPage4.Controls.Add(this.efekt_onceligi);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(548, 128);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Diğer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pwm_uyku
            // 
            this.pwm_uyku.Enabled = false;
            this.pwm_uyku.Location = new System.Drawing.Point(16, 84);
            this.pwm_uyku.Maximum = 255;
            this.pwm_uyku.Name = "pwm_uyku";
            this.pwm_uyku.Size = new System.Drawing.Size(125, 23);
            this.pwm_uyku.TabIndex = 31;
            // 
            // uyku_sure_azalt
            // 
            this.uyku_sure_azalt.AutoSize = true;
            this.uyku_sure_azalt.Checked = true;
            this.uyku_sure_azalt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uyku_sure_azalt.Enabled = false;
            this.uyku_sure_azalt.Location = new System.Drawing.Point(156, 90);
            this.uyku_sure_azalt.Name = "uyku_sure_azalt";
            this.uyku_sure_azalt.Size = new System.Drawing.Size(105, 17);
            this.uyku_sure_azalt.TabIndex = 30;
            this.uyku_sure_azalt.Text = "Yavaşça Söndür";
            this.uyku_sure_azalt.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Uyku Modu (dk)";
            // 
            // uyku_suresi
            // 
            this.uyku_suresi.Enabled = false;
            this.uyku_suresi.Location = new System.Drawing.Point(156, 58);
            this.uyku_suresi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uyku_suresi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uyku_suresi.Name = "uyku_suresi";
            this.uyku_suresi.Size = new System.Drawing.Size(105, 20);
            this.uyku_suresi.TabIndex = 28;
            this.uyku_suresi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(13, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Efektler";
            // 
            // efekt_modlari
            // 
            this.efekt_modlari.FormattingEnabled = true;
            this.efekt_modlari.Items.AddRange(new object[] {
            "Polis",
            "İtfaye",
            "Ambulans",
            "Sakinleştirici",
            "Uyku",
            "Flash"});
            this.efekt_modlari.Location = new System.Drawing.Point(85, 12);
            this.efekt_modlari.Name = "efekt_modlari";
            this.efekt_modlari.Size = new System.Drawing.Size(456, 21);
            this.efekt_modlari.TabIndex = 26;
            this.efekt_modlari.Text = "Lütfen bir efekt seçin.";
            this.efekt_modlari.SelectedIndexChanged += new System.EventHandler(this.efekt_modlari_SelectedIndexChanged);
            // 
            // efekti_baslat
            // 
            this.efekti_baslat.Location = new System.Drawing.Point(348, 90);
            this.efekti_baslat.Name = "efekti_baslat";
            this.efekti_baslat.Size = new System.Drawing.Size(193, 26);
            this.efekti_baslat.TabIndex = 25;
            this.efekti_baslat.Text = "Başlat";
            this.efekti_baslat.UseVisualStyleBackColor = true;
            this.efekti_baslat.Click += new System.EventHandler(this.efekti_baslat_Click);
            // 
            // efekt_onceligi
            // 
            this.efekt_onceligi.FormattingEnabled = true;
            this.efekt_onceligi.Items.AddRange(new object[] {
            "Düşük",
            "Ekonomi",
            "Normal",
            "Performans",
            "Yüksek Performans"});
            this.efekt_onceligi.Location = new System.Drawing.Point(350, 55);
            this.efekt_onceligi.Name = "efekt_onceligi";
            this.efekt_onceligi.Size = new System.Drawing.Size(191, 21);
            this.efekt_onceligi.TabIndex = 24;
            this.efekt_onceligi.Text = "Yüksek Performans";
            // 
            // periyodik_kontrol
            // 
            this.periyodik_kontrol.Tick += new System.EventHandler(this.periyodik_kontrol_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Akıllı RGB LED Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anlik_goruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yatay_led)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dikey_led)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cekirdek_onemi.ResumeLayout(false);
            this.cekirdek_onemi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dikey_derinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yatay_derinlik)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukseltme)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyku_suresi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown yatay_led;
        private System.Windows.Forms.NumericUpDown dikey_led;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button baglan_b;
        private System.Windows.Forms.ComboBox haberlesme_hiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox portlar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cekirdek_onemi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ProgressBar blue_prog;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ProgressBar red_prog;
        private System.Windows.Forms.ProgressBar green_prog;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label baglanti_bildirim;
        private System.Windows.Forms.Timer periyodik_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label genislik_text;
        private System.Windows.Forms.Label yukseklik_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sol_bol;
        private System.Windows.Forms.Label sag_bol;
        private System.Windows.Forms.Label alt_bol;
        private System.Windows.Forms.Label ust_bol;
        private System.Windows.Forms.TrackBar dikey_derinlik;
        private System.Windows.Forms.TrackBar yatay_derinlik;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button hesaplama_buton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sol_alan;
        private System.Windows.Forms.Label sag_alan;
        private System.Windows.Forms.Label alt_alan;
        private System.Windows.Forms.Label ust_alan;
        private System.Windows.Forms.Button calistir_buton;
        private System.Windows.Forms.PictureBox anlik_goruntu;
        private System.Windows.Forms.ComboBox fps_isci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ortam_muzik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar yukseltme;
        private System.Windows.Forms.Button muzik_calistir;
        private System.Windows.Forms.ComboBox isci_music_oncelik;
        private System.Windows.Forms.ComboBox music_modu;
        private System.Windows.Forms.ProgressBar ortam_music_seviyesi;
        private System.Windows.Forms.CheckBox muzik_seviye_goster;
        private System.Windows.Forms.Button efekti_baslat;
        private System.Windows.Forms.ComboBox efekt_onceligi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox efekt_modlari;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label fps_degeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown uyku_suresi;
        private System.Windows.Forms.CheckBox uyku_sure_azalt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label kalan_dk;
        private System.Windows.Forms.ProgressBar pwm_uyku;
    }
}

