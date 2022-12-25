namespace RecycleCoin
{
    partial class frmKullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_donusum = new System.Windows.Forms.Button();
            this.lbl_adetDegeri2 = new System.Windows.Forms.Label();
            this.lbl_adetDegeri = new System.Windows.Forms.Label();
            this.lbl_geriDonusumTuru = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.lbl_nesneTürü = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_nesneler = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_bilgiGetir = new System.Windows.Forms.Button();
            this.txt_tcNo3 = new System.Windows.Forms.TextBox();
            this.lbl_recycleCoin2 = new System.Windows.Forms.Label();
            this.lbl_rcycleCoin = new System.Windows.Forms.Label();
            this.lbl_carbonSayisi2 = new System.Windows.Forms.Label();
            this.lbl_carbonSayisi = new System.Windows.Forms.Label();
            this.lbl_tcNo3 = new System.Windows.Forms.Label();
            this.lbl_soyisim4 = new System.Windows.Forms.Label();
            this.lbl_soyisim3 = new System.Windows.Forms.Label();
            this.lbl_isim4 = new System.Windows.Forms.Label();
            this.lbl_isim3 = new System.Windows.Forms.Label();
            this.lbl_Sha2 = new System.Windows.Forms.Label();
            this.lbl_Sha1 = new System.Windows.Forms.Label();
            this.txt_tcNo4 = new System.Windows.Forms.TextBox();
            this.lbl_tcNo5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_tcNo4);
            this.tabPage1.Controls.Add(this.lbl_tcNo5);
            this.tabPage1.Controls.Add(this.btn_donusum);
            this.tabPage1.Controls.Add(this.lbl_adetDegeri2);
            this.tabPage1.Controls.Add(this.lbl_adetDegeri);
            this.tabPage1.Controls.Add(this.lbl_geriDonusumTuru);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lbl_adet);
            this.tabPage1.Controls.Add(this.txt_adet);
            this.tabPage1.Controls.Add(this.lbl_nesneTürü);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmb_nesneler);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GeriDönüşüm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_donusum
            // 
            this.btn_donusum.Location = new System.Drawing.Point(496, 308);
            this.btn_donusum.Name = "btn_donusum";
            this.btn_donusum.Size = new System.Drawing.Size(86, 34);
            this.btn_donusum.TabIndex = 31;
            this.btn_donusum.Text = "Dönüştür";
            this.btn_donusum.UseVisualStyleBackColor = true;
            this.btn_donusum.Click += new System.EventHandler(this.btn_donusum_Click);
            // 
            // lbl_adetDegeri2
            // 
            this.lbl_adetDegeri2.AutoSize = true;
            this.lbl_adetDegeri2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adetDegeri2.Location = new System.Drawing.Point(406, 200);
            this.lbl_adetDegeri2.Name = "lbl_adetDegeri2";
            this.lbl_adetDegeri2.Size = new System.Drawing.Size(0, 21);
            this.lbl_adetDegeri2.TabIndex = 30;
            // 
            // lbl_adetDegeri
            // 
            this.lbl_adetDegeri.AutoSize = true;
            this.lbl_adetDegeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adetDegeri.Location = new System.Drawing.Point(406, 151);
            this.lbl_adetDegeri.Name = "lbl_adetDegeri";
            this.lbl_adetDegeri.Size = new System.Drawing.Size(160, 21);
            this.lbl_adetDegeri.TabIndex = 29;
            this.lbl_adetDegeri.Text = "Adet Carbon Değeri";
            // 
            // lbl_geriDonusumTuru
            // 
            this.lbl_geriDonusumTuru.AutoSize = true;
            this.lbl_geriDonusumTuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_geriDonusumTuru.Location = new System.Drawing.Point(218, 204);
            this.lbl_geriDonusumTuru.Name = "lbl_geriDonusumTuru";
            this.lbl_geriDonusumTuru.Size = new System.Drawing.Size(0, 21);
            this.lbl_geriDonusumTuru.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Geri Dönüşüm İşlemi";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adet.Location = new System.Drawing.Point(607, 151);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(105, 21);
            this.lbl_adet.TabIndex = 22;
            this.lbl_adet.Text = "Adet Miktarı";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(607, 202);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 23);
            this.txt_adet.TabIndex = 21;
            // 
            // lbl_nesneTürü
            // 
            this.lbl_nesneTürü.AutoSize = true;
            this.lbl_nesneTürü.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nesneTürü.Location = new System.Drawing.Point(194, 151);
            this.lbl_nesneTürü.Name = "lbl_nesneTürü";
            this.lbl_nesneTürü.Size = new System.Drawing.Size(157, 21);
            this.lbl_nesneTürü.TabIndex = 20;
            this.lbl_nesneTürü.Text = "Geri Dönüşüm Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nesneler";
            // 
            // cmb_nesneler
            // 
            this.cmb_nesneler.FormattingEnabled = true;
            this.cmb_nesneler.Items.AddRange(new object[] {
            "0,5lt pet şişe ",
            "0,33 alüminyum kola kutusu ",
            "Gazete",
            "1lt pet şişe",
            "1.5lt pet şişe",
            "2lt pet şişe",
            "2.5lt pet şişe",
            "5lt pet şişe",
            "0.5lt cam şişe",
            "1lt cam şişe",
            "1.5lt cam şişe",
            "2lt cam şişe"});
            this.cmb_nesneler.Location = new System.Drawing.Point(37, 200);
            this.cmb_nesneler.Name = "cmb_nesneler";
            this.cmb_nesneler.Size = new System.Drawing.Size(121, 23);
            this.cmb_nesneler.TabIndex = 17;
            this.cmb_nesneler.SelectedIndexChanged += new System.EventHandler(this.cmb_nesneler_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_bilgiGetir);
            this.tabPage2.Controls.Add(this.txt_tcNo3);
            this.tabPage2.Controls.Add(this.lbl_recycleCoin2);
            this.tabPage2.Controls.Add(this.lbl_rcycleCoin);
            this.tabPage2.Controls.Add(this.lbl_carbonSayisi2);
            this.tabPage2.Controls.Add(this.lbl_carbonSayisi);
            this.tabPage2.Controls.Add(this.lbl_tcNo3);
            this.tabPage2.Controls.Add(this.lbl_soyisim4);
            this.tabPage2.Controls.Add(this.lbl_soyisim3);
            this.tabPage2.Controls.Add(this.lbl_isim4);
            this.tabPage2.Controls.Add(this.lbl_isim3);
            this.tabPage2.Controls.Add(this.lbl_Sha2);
            this.tabPage2.Controls.Add(this.lbl_Sha1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_bilgiGetir
            // 
            this.btn_bilgiGetir.Location = new System.Drawing.Point(499, 48);
            this.btn_bilgiGetir.Name = "btn_bilgiGetir";
            this.btn_bilgiGetir.Size = new System.Drawing.Size(113, 35);
            this.btn_bilgiGetir.TabIndex = 13;
            this.btn_bilgiGetir.Text = "Bilgileri Getir";
            this.btn_bilgiGetir.UseVisualStyleBackColor = true;
            this.btn_bilgiGetir.Click += new System.EventHandler(this.btn_bilgiGetir_Click);
            // 
            // txt_tcNo3
            // 
            this.txt_tcNo3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tcNo3.Location = new System.Drawing.Point(260, 53);
            this.txt_tcNo3.Name = "txt_tcNo3";
            this.txt_tcNo3.Size = new System.Drawing.Size(193, 25);
            this.txt_tcNo3.TabIndex = 12;
            // 
            // lbl_recycleCoin2
            // 
            this.lbl_recycleCoin2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_recycleCoin2.Location = new System.Drawing.Point(273, 452);
            this.lbl_recycleCoin2.Name = "lbl_recycleCoin2";
            this.lbl_recycleCoin2.Size = new System.Drawing.Size(178, 23);
            this.lbl_recycleCoin2.TabIndex = 11;
            // 
            // lbl_rcycleCoin
            // 
            this.lbl_rcycleCoin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rcycleCoin.Location = new System.Drawing.Point(79, 452);
            this.lbl_rcycleCoin.Name = "lbl_rcycleCoin";
            this.lbl_rcycleCoin.Size = new System.Drawing.Size(175, 23);
            this.lbl_rcycleCoin.TabIndex = 10;
            this.lbl_rcycleCoin.Text = "RecycleCoin Sayısı:";
            // 
            // lbl_carbonSayisi2
            // 
            this.lbl_carbonSayisi2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_carbonSayisi2.Location = new System.Drawing.Point(273, 365);
            this.lbl_carbonSayisi2.Name = "lbl_carbonSayisi2";
            this.lbl_carbonSayisi2.Size = new System.Drawing.Size(178, 23);
            this.lbl_carbonSayisi2.TabIndex = 9;
            // 
            // lbl_carbonSayisi
            // 
            this.lbl_carbonSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_carbonSayisi.Location = new System.Drawing.Point(121, 365);
            this.lbl_carbonSayisi.Name = "lbl_carbonSayisi";
            this.lbl_carbonSayisi.Size = new System.Drawing.Size(133, 23);
            this.lbl_carbonSayisi.TabIndex = 8;
            this.lbl_carbonSayisi.Text = "Carbon Sayisi:";
            // 
            // lbl_tcNo3
            // 
            this.lbl_tcNo3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tcNo3.Location = new System.Drawing.Point(116, 55);
            this.lbl_tcNo3.Name = "lbl_tcNo3";
            this.lbl_tcNo3.Size = new System.Drawing.Size(138, 23);
            this.lbl_tcNo3.TabIndex = 6;
            this.lbl_tcNo3.Text = "TC No Giriniz:";
            // 
            // lbl_soyisim4
            // 
            this.lbl_soyisim4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyisim4.Location = new System.Drawing.Point(273, 282);
            this.lbl_soyisim4.Name = "lbl_soyisim4";
            this.lbl_soyisim4.Size = new System.Drawing.Size(178, 23);
            this.lbl_soyisim4.TabIndex = 5;
            // 
            // lbl_soyisim3
            // 
            this.lbl_soyisim3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyisim3.Location = new System.Drawing.Point(168, 282);
            this.lbl_soyisim3.Name = "lbl_soyisim3";
            this.lbl_soyisim3.Size = new System.Drawing.Size(86, 23);
            this.lbl_soyisim3.TabIndex = 4;
            this.lbl_soyisim3.Text = "Soyisim:";
            // 
            // lbl_isim4
            // 
            this.lbl_isim4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_isim4.Location = new System.Drawing.Point(273, 200);
            this.lbl_isim4.Name = "lbl_isim4";
            this.lbl_isim4.Size = new System.Drawing.Size(178, 23);
            this.lbl_isim4.TabIndex = 3;
            // 
            // lbl_isim3
            // 
            this.lbl_isim3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_isim3.Location = new System.Drawing.Point(195, 200);
            this.lbl_isim3.Name = "lbl_isim3";
            this.lbl_isim3.Size = new System.Drawing.Size(59, 23);
            this.lbl_isim3.TabIndex = 2;
            this.lbl_isim3.Text = "İsim:";
            // 
            // lbl_Sha2
            // 
            this.lbl_Sha2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sha2.Location = new System.Drawing.Point(260, 130);
            this.lbl_Sha2.Name = "lbl_Sha2";
            this.lbl_Sha2.Size = new System.Drawing.Size(178, 23);
            this.lbl_Sha2.TabIndex = 1;
            // 
            // lbl_Sha1
            // 
            this.lbl_Sha1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sha1.Location = new System.Drawing.Point(76, 130);
            this.lbl_Sha1.Name = "lbl_Sha1";
            this.lbl_Sha1.Size = new System.Drawing.Size(178, 23);
            this.lbl_Sha1.TabIndex = 0;
            this.lbl_Sha1.Text = "SHA-256 Adresi :";
            // 
            // txt_tcNo4
            // 
            this.txt_tcNo4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tcNo4.Location = new System.Drawing.Point(181, 313);
            this.txt_tcNo4.Name = "txt_tcNo4";
            this.txt_tcNo4.Size = new System.Drawing.Size(193, 25);
            this.txt_tcNo4.TabIndex = 33;
            // 
            // lbl_tcNo5
            // 
            this.lbl_tcNo5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tcNo5.Location = new System.Drawing.Point(37, 315);
            this.lbl_tcNo5.Name = "lbl_tcNo5";
            this.lbl_tcNo5.Size = new System.Drawing.Size(138, 23);
            this.lbl_tcNo5.TabIndex = 32;
            this.lbl_tcNo5.Text = "TC No Giriniz:";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 670);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        public TabPage tabPage1;
        public Label lbl_carbonSayisi2;
        public Label lbl_carbonSayisi;
        public Label lbl_soyisim4;
        public Label lbl_soyisim3;
        public Label lbl_isim4;
        public Label lbl_isim3;
        public Label lbl_Sha2;
        public Label lbl_Sha1;
        public Label lbl_recycleCoin2;
        public Label lbl_rcycleCoin;
        public TextBox txt_tcNo3;
        public Label lbl_tcNo3;
        private Button btn_bilgiGetir;
        public TabPage tabPage2;
        private Button btn_donusum;
        private Label lbl_adetDegeri2;
        private Label lbl_adetDegeri;
        private Label lbl_geriDonusumTuru;
        private Label label8;
        private Label lbl_adet;
        private TextBox txt_adet;
        private Label lbl_nesneTürü;
        private Label label1;
        private ComboBox cmb_nesneler;
        public TextBox txt_tcNo4;
        public Label lbl_tcNo5;
    }
}