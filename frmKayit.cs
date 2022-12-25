using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btn_kayit2_Click(object sender, EventArgs e)
        {
            
            Kullanici kullanici = new Kullanici();
            kullanici.YeniKullaniciEkle(txt_isim2.Text, txt_soyisim2.Text, txt_tcNo2.Text, txt_sifre2.Text,kullanici.getSha(txt_isim2.Text).ToString(), kullanici.carbonSayisi, kullanici.recycleCoin);
            MessageBox.Show("Kayıt Başarılı");
            this.Close();
        }
    }
}
