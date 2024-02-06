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
        bool mukerrerMusteriDurum; //müşteri mükerrer kontrol
        bool musteriaramaDurum; // müşteri arama kontrol     
        bool mukerrerHesapDurum; // hesap numarsi mükerrer kontrol     

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

        void musteriMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Musteriler where Musteri_Numarasi=@Musteri_Numarasi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Musteri_Numarasi", txtMusteriNumarasi.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                mukerrerMusteriDurum = true;
            }
            else
            {
                mukerrerMusteriDurum = false;
            }
            bgl.baglanti().Close();
        }


        void hesaplarMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hesaplar where Hesap_Numarasi=@Hesap_Numarasi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Hesap_Numarasi", cmbHesapNumaralari.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                mukerrerHesapDurum = true;
            }
            else
            {
                mukerrerHesapDurum = false;
            }
            bgl.baglanti().Close();
        }


        void musteriAramaKayitlimi()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Musteriler where Musteri_Numarasi=@Musteri_Numarasi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Musteri_Numarasi", barAramaTxt.EditValue);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                musteriaramaDurum = true;
            }
            else
            {
                musteriaramaDurum = false;
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
                pnlMusteriHesapAc.Visible = false;
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
            pnlMusteriHesapAc.Visible = false;
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
            pnlMusteriHesapAc.Visible = false;
            pnlIslemTurleri.Visible = true;       

        }

        private void barMusteriYeniHesapAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            pnlKullaniciIslemleri.Visible = false;
            pnlIslemTurleri.Visible = false;
            pnlMusteriHesapAc.Visible = true;
            txtMusteriNumarasi.Enabled = true;

            txtMusteriAd.Text = "";
            txtMusteriSoyad.Text = "";
            txtMusteriTelefon.Text = "";
            txtMusteriEmail.Text = "";
            rchMusteriAdres.Text = "";
            txtMusteriNumarasi.Text = "";
            cmbHesapNumaralari.Text = "";

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

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            //Tüm alanlarda girişi zorunlu tuttuk
            if
                (
                string.IsNullOrEmpty(txtMusteriAd.Text) ||
                string.IsNullOrEmpty(txtMusteriSoyad.Text) ||
                string.IsNullOrEmpty(txtMusteriTelefon.Text) ||
                string.IsNullOrEmpty(txtMusteriEmail.Text) ||
                string.IsNullOrEmpty(rchMusteriAdres.Text) ||
                string.IsNullOrEmpty(txtMusteriNumarasi.Text) 
                )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

            //musteri numarası 11 karakter olarak belirledik
            if (txtMusteriNumarasi.Text.Length > 7 || txtMusteriNumarasi.Text.Length < 7)
            {
                MessageBox.Show("Müşteri Numarası 7 karakterden büyük veya küçük olamaz");
                return;
            }

            //musteri cep telefonu 11 karakter olarak belirledik
            if (txtMusteriTelefon.Text.Length > 11 || txtMusteriTelefon.Text.Length < 11)
            {
                MessageBox.Show("Müşteri Telefon Numarası 11 karakterden büyük veya küçük olamaz");
                return;
            }

            musteriMukerrerKontrol();//mükerrer varmı kontrol et
            if (mukerrerMusteriDurum == false) //yoksa kayit et
            {
                SqlCommand musteriEkleKomutu = new SqlCommand("insert into Tbl_Musteriler (Musteri_Ad,Musteri_Soyad,Musteri_Telefon,Musteri_Email,Musteri_Adres,Musteri_Numarasi) values(@Musteri_Ad,@Musteri_Soyad,@Musteri_Telefon,@Musteri_Email,@Musteri_Adres,@Musteri_Numarasi)", bgl.baglanti());
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Ad", txtMusteriAd.Text);
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Soyad", txtMusteriSoyad.Text);
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Telefon", txtMusteriTelefon.Text);
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Email", txtMusteriEmail.Text);
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Adres", rchMusteriAdres.Text);
                musteriEkleKomutu.Parameters.AddWithValue("@Musteri_Numarasi", txtMusteriNumarasi.Text);
                musteriEkleKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
            }

            else
            {
                XtraMessageBox.Show("Kayıtlı Müşteri Numarası tekrar deneyiniz");
            }
        }

        private void barMusteriBilgiGetir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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


            musteriAramaKayitlimi();
            if (musteriaramaDurum == true)
            {
                pnlMusteriHesapAc.Visible = true;
                pnlIslemTurleri.Visible = false;
                pnlKullaniciIslemleri.Visible = false;               
                txtMusteriNumarasi.Enabled = false;

                SqlCommand musteriAramaKomutu = new SqlCommand(
                   "Select * from Tbl_Musteriler where Musteri_Numarasi = @Musteri_Numarasi", bgl.baglanti());
                musteriAramaKomutu.Parameters.AddWithValue("@Musteri_Numarasi", barAramaTxt.EditValue);

                SqlDataReader musteriVerisiniOku = musteriAramaKomutu.ExecuteReader();

                while (musteriVerisiniOku.Read())
                {
                    txtMusteriAd.Text = musteriVerisiniOku[1].ToString();
                    txtMusteriSoyad.Text = musteriVerisiniOku[2].ToString();
                    txtMusteriTelefon.Text = musteriVerisiniOku[3].ToString();
                    txtMusteriEmail.Text = musteriVerisiniOku[4].ToString();
                    rchMusteriAdres.Text = musteriVerisiniOku[5].ToString();
                    txtMusteriNumarasi.Text = musteriVerisiniOku[6].ToString();
                }

                bgl.baglanti().Close();
            }

            else
            {
                XtraMessageBox.Show("Lütfen kayıtlı müşteri numarası giriniz adı giriniz");
                pnlMusteriHesapAc.Visible = false;
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            //Tüm alanlarda girişi zorunlu tuttuk
            if
                (
                string.IsNullOrEmpty(txtMusteriAd.Text) ||
                string.IsNullOrEmpty(txtMusteriSoyad.Text) ||
                string.IsNullOrEmpty(txtMusteriTelefon.Text) ||
                string.IsNullOrEmpty(txtMusteriEmail.Text) ||
                string.IsNullOrEmpty(rchMusteriAdres.Text) ||
                string.IsNullOrEmpty(txtMusteriNumarasi.Text)
                )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

            //musteri numarası 11 karakter olarak belirledik
            if (txtMusteriNumarasi.Text.Length > 7 || txtMusteriNumarasi.Text.Length < 7)
            {
                MessageBox.Show("Müşteri Numarası 7 karakterden büyük veya küçük olamaz");
                return;
            }

            //musteri cep telefonu 11 karakter olarak belirledik
            if (txtMusteriTelefon.Text.Length > 11 || txtMusteriTelefon.Text.Length < 11)
            {
                MessageBox.Show("Müşteri Telefon Numarası 11 karakterden büyük veya küçük olamaz");
                return;
            }
           
                SqlCommand musteriGuncellemeKomutu = new SqlCommand("UPDATE Tbl_Musteriler SET Musteri_Ad=@Musteri_Ad,Musteri_Soyad=@Musteri_Soyad,Musteri_Telefon=@Musteri_Telefon,Musteri_Email=@Musteri_Email,Musteri_Adres=@Musteri_Adres WHERE Musteri_Numarasi=@Musteri_Numarasi", bgl.baglanti());
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Ad", txtMusteriAd.Text);
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Soyad", txtMusteriSoyad.Text);
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Telefon", txtMusteriTelefon.Text);
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Email", txtMusteriEmail.Text);
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Adres", rchMusteriAdres.Text);
                musteriGuncellemeKomutu.Parameters.AddWithValue("@Musteri_Numarasi", txtMusteriNumarasi.Text);
                musteriGuncellemeKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Müşteri Güncelleme İşlemi Başarılı");            
        }

        private void btnHesaplariGetir_Click(object sender, EventArgs e)
        {

            //Tüm alanlarda girişi zorunlu tuttuk
            if
                (
                string.IsNullOrEmpty(txtMusteriNumarasi.Text)                
                )
            {
                MessageBox.Show("Lütfen Müşteri Numarası alanını doldurunuz");
                return;
            }

            //cmbHesapNumaralari.Items.Clear(); //hesapları getire basınca önce buton içindekileri temizleyecek
            cmbHesapNumaralari.Properties.Items.Clear();
            cmbHesapNumaralari.Text = "";

            //müşterinin hesaplarını listeledik
            SqlCommand musteriHesapListelemeKomutu = new SqlCommand("Select Hesap_Numarasi From Tbl_Hesaplar where Musteri_Numarasi=@Musteri_Numarasi", bgl.baglanti());
            musteriHesapListelemeKomutu.Parameters.AddWithValue("Musteri_Numarasi",txtMusteriNumarasi.Text);
            //musteriHesapListelemeKomutu.ExecuteNonQuery();
            SqlDataReader musteriHesapOku = musteriHesapListelemeKomutu.ExecuteReader();
            while (musteriHesapOku.Read())
            {
                cmbHesapNumaralari.Properties.Items.Add(musteriHesapOku[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if
               (
               string.IsNullOrEmpty(txtMusteriNumarasi.Text) ||
                string.IsNullOrEmpty(cmbHesapNumaralari.Text)
               )
            {
                MessageBox.Show("Lütfen Müşteri Numarası veya Hesap Numarası alanlarını doldurunuz");
                return;
            }

            //müşterinin hesaplarını listeledik
            SqlCommand musteriHesapListelemeKomutu = new SqlCommand("Select Hesap_Bakiyesi From Tbl_Hesaplar where Hesap_Numarasi=@Hesap_Numarasi", bgl.baglanti());
            musteriHesapListelemeKomutu.Parameters.AddWithValue("Hesap_Numarasi", cmbHesapNumaralari.Text);
            SqlDataReader musteriHesapListelemeOku = musteriHesapListelemeKomutu.ExecuteReader();

            // Veriyi okuma işlemi
            if (musteriHesapListelemeOku.Read())
            {
                // Hesap bakiyesini alabilirsiniz
                decimal hesapBakiyesi = musteriHesapListelemeOku.GetDecimal(0);
                if (hesapBakiyesi > 0)
                {
                    // İşlemleri gerçekleştirin...
                    XtraMessageBox.Show("Hesap Bakiyesi 0 dan büyük ise hesap kapatılamaz Hesap Bakiyesi : " + hesapBakiyesi);
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show(" Belirtilen hesap numarasına ait kayıt bulunamadı !!!");
                return;
            }
            bgl.baglanti().Close();

            SqlCommand musteriSilmeKomutu = new SqlCommand("DELETE FROM Tbl_Hesaplar WHERE Hesap_Numarasi=@Hesap_Numarasi", bgl.baglanti());
            musteriSilmeKomutu.Parameters.AddWithValue("@Hesap_Numarasi", cmbHesapNumaralari.Text);
            musteriSilmeKomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Hesap Silme İşlemi Başarılı");
            cmbHesapNumaralari.Properties.Items.Clear(); //bosalt hesapnumaralarini
            cmbHesapNumaralari.Text = "";
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if
              (
              string.IsNullOrEmpty(txtMusteriNumarasi.Text) ||
               string.IsNullOrEmpty(cmbHesapNumaralari.Text)
              )
            {
                MessageBox.Show("Lütfen Müşteri Numarası veya Hesap Numarası alanlarını doldurunuz");
                return;
            }

            hesaplarMukerrerKontrol();
            if (mukerrerHesapDurum == false)
            {
                SqlCommand musteriEklemeKomutu = new SqlCommand("INSERT INTO Tbl_Hesaplar (Musteri_Numarasi,Hesap_Numarasi,Hesap_Bakiyesi,Hesap_KulBakiye) VALUES (@Musteri_Numarasi,@Hesap_Numarasi,@Hesap_Bakiyesi,@Hesap_KulBakiye)", bgl.baglanti());
                musteriEklemeKomutu.Parameters.AddWithValue("@Musteri_Numarasi", txtMusteriNumarasi.Text);
                musteriEklemeKomutu.Parameters.AddWithValue("@Hesap_Numarasi", cmbHesapNumaralari.Text);
                musteriEklemeKomutu.Parameters.AddWithValue("@Hesap_Bakiyesi", 0);
                musteriEklemeKomutu.Parameters.AddWithValue("@Hesap_KulBakiye", 0);
                musteriEklemeKomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Hesap Ekleme İşlemi Başarılı");
                cmbHesapNumaralari.Properties.Items.Clear(); //bosalt hesapnumaralarini
                cmbHesapNumaralari.Text = "";
            }           

            else
            {
                XtraMessageBox.Show("Hesap Numarası sisteme kayıtlıdır lütfen farklı hesap numarası giriniz");
            }

        }

        private void barBankaRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
