namespace RecycleCoin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(370, 267);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(87, 31);
            this.btn_kayit.TabIndex = 19;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(225, 267);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(91, 31);
            this.btn_giris.TabIndex = 18;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(225, 194);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(232, 23);
            this.txt_sifre.TabIndex = 17;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(225, 110);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(232, 23);
            this.txt_tcNo.TabIndex = 16;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sifre.Location = new System.Drawing.Point(156, 197);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(47, 20);
            this.lbl_sifre.TabIndex = 15;
            this.lbl_sifre.Text = "Sifre";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tcNo.Location = new System.Drawing.Point(148, 113);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(55, 20);
            this.lbl_tcNo.TabIndex = 14;
            this.lbl_tcNo.Text = "Tc No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tcNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_kayit;
        private Button btn_giris;
        private TextBox txt_sifre;
        private Label lbl_sifre;
        private Label lbl_tcNo;
        public TextBox txt_tcNo;
    }
}