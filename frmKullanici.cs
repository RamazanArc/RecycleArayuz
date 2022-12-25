using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace RecycleCoin
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btn_bilgiGetir_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select isim,soyisim,shaAdresi,carbonSayisi,recycleCoin from kullanici where tcNo like '"+txt_tcNo3.Text.ToString()+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lbl_Sha2.Text = read["shaAdresi"].ToString();
                lbl_recycleCoin2.Text = read["recycleCoin"].ToString() ;
                lbl_soyisim4.Text = read["soyisim"].ToString();
                lbl_isim4.Text = read["isim"].ToString();
                lbl_carbonSayisi2.Text = read["carbonSayisi"].ToString();
               
            }
            baglanti.Close();
           
            
        }

        private void txt_tcNo3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_nesneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select donusumTuru,carbonDegeri from nesne where nesne like '" + cmb_nesneler.Text.ToString() + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lbl_geriDonusumTuru.Text = read["donusumTuru"].ToString();
                lbl_adetDegeri2.Text = read["carbonDegeri"].ToString();

            }
            baglanti.Close();
        }

        private void btn_donusum_Click(object sender, EventArgs e)
        {
            int rcyc = 100000000;
            int adet2 = 0;
            string carbonDegeri;
            int carbonDegeri2 = 0;
            string adet;
            int sonuc = 0;
            adet = txt_adet.Text;
            adet2 = Convert.ToInt32(adet);
            carbonDegeri = lbl_adetDegeri2.Text;
            carbonDegeri2 = Convert.ToInt32(carbonDegeri);

            sonuc = adet2 * carbonDegeri2;
            MessageBox.Show("Tebrikler " +sonuc.ToString()+ " Carbon Kazandınız" );

            SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select carbonSayisi,recycleCoin from kullanici where tcNo like '" + txt_tcNo4.Text.ToString() + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                string carbon = read["carbonSayisi"].ToString();
                string recycle = read["recycleCoin"].ToString();
                int carbon2 = Convert.ToInt32(carbon);
                int recycle2 = Convert.ToInt32(recycle);
                SqlConnection baglanti2 = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
                SqlCommand komut2 = new SqlCommand("update kullanici set carbonSayisi =@carbonSayisi where tcNo = @tcNo", baglanti2);
                komut2.Parameters.AddWithValue("@tcNo", txt_tcNo4.Text);
                komut2.Parameters.AddWithValue("@carbonSayisi", carbon2 + sonuc);
                baglanti2.Open();
                komut2.ExecuteNonQuery();
                baglanti2.Close();
                string carbon3 = read["carbonSayisi"].ToString();
                int carbon4 = Convert.ToInt32(carbon);
                if(carbon4 >= 100000000)
                {
                    SqlConnection baglanti3 = new SqlConnection(@"data source = DESKTOP-K72V513;database = coin;integrated security= True;Trust Server Certificate=true");
                    SqlCommand komut3 = new SqlCommand("update kullanici set carbonSayisi =@carbonSayisi,recycleCoin=@recycleCoin where tcNo = @tcNo", baglanti3);
                    komut3.Parameters.AddWithValue("@tcNo", txt_tcNo4.Text);
                    komut3.Parameters.AddWithValue("@carbonsayisi",(carbon4-100000000).ToString());
                    komut3.Parameters.AddWithValue("@recycleCoin", (recycle2 + 1).ToString());
                    baglanti3.Open();
                    komut3.ExecuteNonQuery();
                    baglanti3.Close();

                }
            }
            
            baglanti.Close();






        }
    }
}
