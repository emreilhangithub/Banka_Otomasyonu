using System;
using System.Data;
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
        bool mukerrerDurum;//mukerrer kontrol kullanıcı
        bool aramaDurum; //arama butonu kontrol
        bool islemDurum; //işlem türü kontrol
       

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            //işlem türlerini listeledik
            SqlCommand islemTuruCekKomutu = new SqlCommand("Select Tur_Ad From Tbl_IslemTuru", bgl.baglanti());
            SqlDataReader islemTuruOku = islemTuruCekKomutu.ExecuteReader();
            while (islemTuruOku.Read())
            {
                CmbIslemTurleri.Properties.Items.Add(islemTuruOku[0]);
            }
            bgl.baglanti().Close();
        }

        void kullaniciMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kullanicilar where Kullanici_Adi=@Kullanici_Adi or Kullanici_Email=@Kullanici_Email", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kullanici_Adi", barAramaTxt.EditValue);
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

        void kullaniciAramaKayitlimi()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kullanicilar where Kullanici_Adi=@Kullanici_Adi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kullanici_Adi", barAramaTxt.EditValue);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                aramaDurum = true;
            }
            else
            {
                aramaDurum = false;
            }
            bgl.baglanti().Close();
        }

        void islemTuruMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_IslemTuru where Tur_Ad=@Tur_Ad", bgl.baglanti());
            komut.Parameters.AddWithValue("@Tur_Ad", txtYeniIslemTuru.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                islemDurum = true;
            }
            else
            {
                islemDurum = false;
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
            if (mukerrerDurum == false) //yoksa kayit et
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
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtKullaniciSil_Click(object sender, EventArgs e)
        {
            if
               (
               string.IsNullOrEmpty(txtKullaniciAdi.Text)
               )
            {
                MessageBox.Show("Lütfen Silmek İstediginiz Kullanıcı Adını Kontrol Ediniz");
                return;
            }

            kullaniciMukerrerKontrol();//mükerrer varmı kontrol et
            if (mukerrerDurum == true) //kayıt varsa sil
            {
                SqlCommand kullaniciSilKomutu = new SqlCommand("delete from Tbl_Kullanicilar where Kullanici_Adi=@Kullanici_Adi", bgl.baglanti());
                kullaniciSilKomutu.Parameters.AddWithValue("@Kullanici_Adi", txtKullaniciAdi.Text);
                kullaniciSilKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kullanıcı Silme İşlemi Başarılı");
                pnlKullaniciIslemleri.Visible = false;
            }

            else
            {
                MessageBox.Show("Lütfen Kayıtlı Bir KullanıcıAdı Giriniz");
            }
        }

        private void txtKullaniciGuncelle_Click(object sender, EventArgs e)
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

            SqlCommand kullaniciGuncellemeKomutu = new SqlCommand("UPDATE Tbl_Kullanicilar SET Kullanici_Sifre=@Kullanici_Sifre,Kullanici_Email=@Kullanici_Email,Kullanici_AdSoyad=@Kullanici_AdSoyad WHERE Kullanici_Adi=@Kullanici_Adi", bgl.baglanti());
            kullaniciGuncellemeKomutu.Parameters.AddWithValue("@Kullanici_Adi", txtKullaniciAdi.Text);
            kullaniciGuncellemeKomutu.Parameters.AddWithValue("@Kullanici_Sifre", txtKullaniciSifre.Text);
            kullaniciGuncellemeKomutu.Parameters.AddWithValue("@Kullanici_Email", txtKullaniciEmail.Text);
            kullaniciGuncellemeKomutu.Parameters.AddWithValue("@Kullanici_AdSoyad", txtKullaniciAdSoyad.Text);
            kullaniciGuncellemeKomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Kullanıcı Güncelleme İşlemi Başarılı");
            //grpKullaniciIslemleri.Visible = false;

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Tüm alanlarda girişi zorunlu tuttuk
            //if (barAramaTxt.EditValue == null )
            //{
            //    MessageBox.Show("Lütfen Arama Kutusunu Doldurunuz");
            //    return;
            //}
            if (string.IsNullOrEmpty(barAramaTxt.EditValue?.ToString()))
            {
                MessageBox.Show("Lütfen Arama Kutusunu Doldurunuz");
                return;
            }


            kullaniciAramaKayitlimi();
            if (aramaDurum == true)
            {
                pnlIslemTurleri.Visible = false;
                pnlKullaniciIslemleri.Visible = true;
                btnKullaniciEkle.Visible = false;
                btnKullaniciGuncelle.Visible = true;
                btnKullaniciSil.Visible = true;
                txtKullaniciAdi.Enabled = false;

                SqlCommand kullaniciAramaKomutu = new SqlCommand(
                   "Select * from Tbl_Kullanicilar where Kullanici_Adi = @Kullanici_Adi", bgl.baglanti());
                kullaniciAramaKomutu.Parameters.AddWithValue("@Kullanici_Adi", barAramaTxt.EditValue);

                SqlDataReader kullaniciVerisiniOku = kullaniciAramaKomutu.ExecuteReader();

                while (kullaniciVerisiniOku.Read())
                {
                    txtKullaniciAdi.Text = kullaniciVerisiniOku[1].ToString();
                    txtKullaniciSifre.Text = kullaniciVerisiniOku[2].ToString();
                    txtKullaniciEmail.Text = kullaniciVerisiniOku[3].ToString();
                    txtKullaniciAdSoyad.Text = kullaniciVerisiniOku[4].ToString();
                }

                bgl.baglanti().Close();
            }

            else
            {
                XtraMessageBox.Show("Lütfen kayıtlı bir kullanıcı adı giriniz");
                pnlKullaniciIslemleri.Visible = false;
            }




        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void btnYeniKullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlIslemTurleri.Visible = false;
            pnlKullaniciIslemleri.Visible = true;
            btnKullaniciEkle.Visible = true;
            btnKullaniciGuncelle.Visible = false;
            btnKullaniciSil.Visible = false;
            txtKullaniciAdi.Enabled = true;

            txtKullaniciAdSoyad.Text = "";
            txtKullaniciAdi.EditValue = "";
            txtKullaniciSifre.EditValue = "";
            txtKullaniciEmail.EditValue = "";

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlKullaniciIslemleri.Visible = false;
            pnlIslemTurleri.Visible = true;
           
           
            
        }

        private void barMusteriYeniHesapAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {           
            //Tüm alanlarda girişi zorunlu tuttuk
            if
                (
                string.IsNullOrEmpty(txtYeniIslemTuru.Text)
                )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

        islemTuruMukerrerKontrol();//mükerrer varmı kontrol et
            if (islemDurum == false) //yoksa kayit et
            {
                SqlCommand IslemEkleKomutu = new SqlCommand("insert into Tbl_IslemTuru (Tur_Ad) values(@Tur_Ad)", bgl.baglanti());
        IslemEkleKomutu.Parameters.AddWithValue("@Tur_Ad", txtYeniIslemTuru.Text);
                IslemEkleKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
        XtraMessageBox.Show("İşlem Ekleme işlemi Başarılı");               
            }

            else
            {
                XtraMessageBox.Show("Bu işlem türü zaten var tekrar deneyiniz");
            }
        }

        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            //Tüm alanlarda girişi zorunlu tuttuk
            if
                (
                string.IsNullOrEmpty(CmbIslemTurleri.Text)
                )
            {
                MessageBox.Show("Lütfen İşlem Türünü Seçiniz");
                return;
            }           
            
                SqlCommand IslemEkleKomutu = new SqlCommand("Delete From Tbl_IslemTuru where Tur_Ad = @Tur_Ad", bgl.baglanti());
                IslemEkleKomutu.Parameters.AddWithValue("@Tur_Ad", CmbIslemTurleri.Text);
                IslemEkleKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("İşlem Silme işlemi Başarılı");               
        }
    }
}
