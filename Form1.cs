namespace RecycleCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            frmKullanici frmKullanici= new frmKullanici();
            Kullanici kullanici= new Kullanici();
            //kullanici.KullaniciGirisi(txt_tcNo.Text, txt_sifre.Text);
            frmKullanici.ShowDialog();
            
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            frmKayit kayit = new frmKayit();
            kayit.ShowDialog();
        }
    }
}