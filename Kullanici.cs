using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace RecycleCoin
{
    public class Kullanici
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string tcNo { get; set; }
        public string shaAdresi { get; set; }
        public float carbonSayisi { get; set; }
        public string sifre { get; set; }
        public float recycleCoin { get; set; }


        public  string getSha(string strword)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strword);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }



        public void YeniKullaniciEkle(string isim, string soyisim, string tcNo, string sifre, string shaAdresi,float carbonSayisi,float recycleCoin)
        {
            
            this.isim = isim;
            this.soyisim = soyisim;
            this.tcNo = tcNo;
            this.sifre = sifre;
            this.carbonSayisi = 0;
            this.recycleCoin = 0;
            this.shaAdresi = getSha(isim);
            SqlCommand komut = new SqlCommand("insert into kullanici(isim,soyisim,tcNo,sifre,shaAdresi,carbonSayisi,recycleCoin) values (@isim,@soyisim,@tcNo,@sifre,@shaAdresi,@carbonSayisi,@recycleCoin)", baglanti);
            komut.Parameters.AddWithValue("@isim", this.isim);
            komut.Parameters.AddWithValue("@soyisim", this.soyisim);
            komut.Parameters.AddWithValue("@tcNo", this.tcNo);
            komut.Parameters.AddWithValue("@sifre", this.sifre);
            komut.Parameters.AddWithValue("@shaAdresi", this.shaAdresi);
            komut.Parameters.AddWithValue("@carbonSayisi", this.carbonSayisi);
            komut.Parameters.AddWithValue("@recycleCoin", this.recycleCoin);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        SqlDataReader oku;
        public SqlDataReader KullaniciGirisi(string tcNo, string sifre)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici where tcNo =@tcNo", baglanti);
            komut.Parameters.Add("@tcNo", SqlDbType.NVarChar).Value = tcNo;
            komut.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre == oku["sifre"].ToString())
                {

                    frmKullanici frmKullanici = new frmKullanici();
                    frmKullanici.ShowDialog();



                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz");
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Komtrol ediniz");
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            baglanti.Close();
            return oku;



        }

    }
  

}



  

