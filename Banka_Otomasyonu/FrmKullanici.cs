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
using DevExpress.XtraEditors;

namespace Banka_Otomasyonu
{
    public partial class FrmKullanici : XtraForm
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        bool mukerrerDurum;//mukerrer kontrol

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
           
        }

        void kullaniciMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kullanicilar where Kullanici_Adi=@Kullanici_Adi or Kullanici_Email=@Kullanici_Email", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kullanici_Adi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@Kullanici_Email", txtKullaniciEmail.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                mukerrerDurum = true;
            }
            else
            {
                mukerrerDurum = false;
            }
            bgl.baglanti().Close();

        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            //Tüm alanlarda girişi zorunlu tuttuk
            if 
                (
                string.IsNullOrEmpty(txtKullaniciAdSoyad.Text) ||
                string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                string.IsNullOrEmpty(txtKullaniciSifre.Text) ||
                string.IsNullOrEmpty(txtKullaniciEmail.Text) ||
                string.IsNullOrEmpty(txtKullaniciAdi.Text) 
                )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

            //şifreyi 8 karakter olarak belirledik
            if (txtKullaniciSifre.Text.Length > 8 || txtKullaniciSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre 8 karakterden büyük veya küçük olamaz");
                return;
            }
            
            kullaniciMukerrerKontrol();//mükerrer varmı kontrol et
            if (mukerrerDurum==false) //yoksa kayit et
            {
                SqlCommand kullaniciEkleKomutu = new SqlCommand("insert into Tbl_Kullanicilar (Kullanici_Adi,Kullanici_Sifre,Kullanici_Email,Kullanici_AdSoyad) values(@Kullanici_Adi,@Kullanici_Sifre,@Kullanici_Email,@Kullanici_AdSoyad)", bgl.baglanti());
                kullaniciEkleKomutu.Parameters.AddWithValue("@Kullanici_Adi", txtKullaniciAdi.Text);
                kullaniciEkleKomutu.Parameters.AddWithValue("@Kullanici_Sifre", txtKullaniciSifre.Text);
                kullaniciEkleKomutu.Parameters.AddWithValue("@Kullanici_Email", txtKullaniciEmail.Text);
                kullaniciEkleKomutu.Parameters.AddWithValue("@Kullanici_AdSoyad", txtKullaniciAdSoyad.Text);
                kullaniciEkleKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı");              
            }

            else
            {
                XtraMessageBox.Show("Kayıtlı Kullanıcı Adı veya Mail adresi tekrar deneyiniz");
            }         

        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==32)
            {
                e.Handled = true; 
            }
        }
    }
}
