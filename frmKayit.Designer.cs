namespace RecycleCoin
{
    partial class frmKayit
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
            this.btn_kayit2 = new System.Windows.Forms.Button();
            this.txt_sifre2 = new System.Windows.Forms.TextBox();
            this.txt_tcNo2 = new System.Windows.Forms.TextBox();
            this.txt_soyisim2 = new System.Windows.Forms.TextBox();
            this.txt_isim2 = new System.Windows.Forms.TextBox();
            this.lbl_sifre2 = new System.Windows.Forms.Label();
            this.lbl_tcNo2 = new System.Windows.Forms.Label();
            this.lbl_soyisim2 = new System.Windows.Forms.Label();
            this.lbl_isim2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayit2
            // 
            this.btn_kayit2.Location = new System.Drawing.Point(322, 222);
            this.btn_kayit2.Name = "btn_kayit2";
            this.btn_kayit2.Size = new System.Drawing.Size(87, 31);
            this.btn_kayit2.TabIndex = 37;
            this.btn_kayit2.Text = "Kayıt Ol";
            this.btn_kayit2.UseVisualStyleBackColor = true;
            this.btn_kayit2.Click += new System.EventHandler(this.btn_kayit2_Click);
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Location = new System.Drawing.Point(177, 166);
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.Size = new System.Drawing.Size(232, 23);
            this.txt_sifre2.TabIndex = 34;
            // 
            // txt_tcNo2
            // 
            this.txt_tcNo2.Location = new System.Drawing.Point(177, 124);
            this.txt_tcNo2.Name = "txt_tcNo2";
            this.txt_tcNo2.Size = new System.Drawing.Size(232, 23);
            this.txt_tcNo2.TabIndex = 33;
            // 
            // txt_soyisim2
            // 
            this.txt_soyisim2.Location = new System.Drawing.Point(177, 82);
            this.txt_soyisim2.Name = "txt_soyisim2";
            this.txt_soyisim2.Size = new System.Drawing.Size(232, 23);
            this.txt_soyisim2.TabIndex = 32;
            // 
            // txt_isim2
            // 
            this.txt_isim2.Location = new System.Drawing.Point(177, 40);
            this.txt_isim2.Name = "txt_isim2";
            this.txt_isim2.Size = new System.Drawing.Size(232, 23);
            this.txt_isim2.TabIndex = 31;
            // 
            // lbl_sifre2
            // 
            this.lbl_sifre2.AutoSize = true;
            this.lbl_sifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sifre2.Location = new System.Drawing.Point(100, 169);
            this.lbl_sifre2.Name = "lbl_sifre2";
            this.lbl_sifre2.Size = new System.Drawing.Size(47, 20);
            this.lbl_sifre2.TabIndex = 29;
            this.lbl_sifre2.Text = "Sifre";
            // 
            // lbl_tcNo2
            // 
            this.lbl_tcNo2.AutoSize = true;
            this.lbl_tcNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tcNo2.Location = new System.Drawing.Point(92, 127);
            this.lbl_tcNo2.Name = "lbl_tcNo2";
            this.lbl_tcNo2.Size = new System.Drawing.Size(55, 20);
            this.lbl_tcNo2.TabIndex = 27;
            this.lbl_tcNo2.Text = "Tc No";
            // 
            // lbl_soyisim2
            // 
            this.lbl_soyisim2.AutoSize = true;
            this.lbl_soyisim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyisim2.Location = new System.Drawing.Point(92, 85);
            this.lbl_soyisim2.Name = "lbl_soyisim2";
            this.lbl_soyisim2.Size = new System.Drawing.Size(63, 20);
            this.lbl_soyisim2.TabIndex = 26;
            this.lbl_soyisim2.Text = "Soyadı";
            // 
            // lbl_isim2
            // 
            this.lbl_isim2.AutoSize = true;
            this.lbl_isim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_isim2.Location = new System.Drawing.Point(120, 43);
            this.lbl_isim2.Name = "lbl_isim2";
            this.lbl_isim2.Size = new System.Drawing.Size(35, 20);
            this.lbl_isim2.TabIndex = 25;
            this.lbl_isim2.Text = "Adı";
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kayit2);
            this.Controls.Add(this.txt_sifre2);
            this.Controls.Add(this.txt_tcNo2);
            this.Controls.Add(this.txt_soyisim2);
            this.Controls.Add(this.txt_isim2);
            this.Controls.Add(this.lbl_sifre2);
            this.Controls.Add(this.lbl_tcNo2);
            this.Controls.Add(this.lbl_soyisim2);
            this.Controls.Add(this.lbl_isim2);
            this.Name = "frmKayit";
            this.Text = "frmKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_kayit2;
        private TextBox txt_sifre2;
        private TextBox txt_tcNo2;
        private TextBox txt_soyisim2;
        private TextBox txt_isim2;
        private Label lbl_sifre2;
        private Label lbl_tcNo2;
        private Label lbl_soyisim2;
        private Label lbl_isim2;
    }
}