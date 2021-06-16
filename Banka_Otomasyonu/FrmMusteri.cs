using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Banka_Otomasyonu
{
    public partial class FrmMusteri : XtraForm
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string MusteriNo;
        string islemtarihi = DateTime.Now.ToString(); //islem tarihi
        bool durum;//mukerrer kontrol

        //bugunun bilgileri yolladık                 
        DateTime dt_Gun_Basla = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
        DateTime dt_Gun_Bitis = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

        void mukerrer()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hesaplar where Hesap_Numarasi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtHavaleHesap.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            bgl.baglanti().Close();

        }

        void islemekle(decimal islemTutari)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Islemler (Hesap_Numarasi,Islem_Turu,Islem_Tarihi,Musteri_Numarasi,Islem_Tutari) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbHesapNo.Text);
            komut2.Parameters.AddWithValue("@p2", LblTurIslem.Text);
            komut2.Parameters.AddWithValue("@p3", islemtarihi);
            komut2.Parameters.AddWithValue("@p4", MusteriNo);
            komut2.Parameters.AddWithValue("@p5",islemTutari);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        void bakiyeListele()
        {
            SqlCommand komut2 = new SqlCommand("Select Hesap_Bakiyesi,Hesap_KulBakiye From Tbl_Hesaplar where Musteri_Numarasi=@p1 and Hesap_Numarasi=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", MusteriNo);
            komut2.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblBakiye.Text = dr2[0].ToString();
                LblKulBakiye.Text = dr2[1].ToString();
            }
            bgl.baglanti().Close();
        }

        void gunlukLimitListele()
        {
            //Müşterinin Günlük limini çektik
            SqlCommand limithesaplakomutu = new SqlCommand
                ("SELECT SUM(Islem_Tutari) as 'GunlukLimit'FROM Tbl_Islemler where Islem_Turu = 3 and Musteri_Numarasi = @Musteri_Numarasi and Hesap_Numarasi = @Hesap_Numarasi and Islem_Tarihi between @dt_Gun_Basla and @dt_Gun_Bitis"
                , bgl.baglanti());
            limithesaplakomutu.Parameters.AddWithValue("@Musteri_Numarasi", MusteriNo);
            limithesaplakomutu.Parameters.AddWithValue("@Hesap_Numarasi", CmbHesapNo.Text);
            limithesaplakomutu.Parameters.AddWithValue("@dt_Gun_Basla", dt_Gun_Basla.ToString());
            limithesaplakomutu.Parameters.AddWithValue("@dt_Gun_Bitis", dt_Gun_Bitis.ToString());
            SqlDataReader limithesapdata = limithesaplakomutu.ExecuteReader();
            while (limithesapdata.Read())
            {
                lblGunlukLimit.Text = limithesapdata[0].ToString();
            }
            bgl.baglanti().Close();
        }




        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            //Müşteri Numarasını giriş formundan taşıdık
            LblMusNo.Text = MusteriNo;

            //Comboxa hesapları çektik müşteriye özel hesapları
            SqlCommand komut2 = new SqlCommand("Select Hesap_Numarasi From Tbl_Hesaplar where Musteri_Numarasi=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", MusteriNo);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbHesapNo.Properties.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                LblTurIslem.Text = 1.ToString();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                LblTurIslem.Text = 2.ToString();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                LblTurIslem.Text = 3.ToString();
            }
        }

        private void CmbHesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboxtan hesap no seçilince veriyi bakiye yazdırma
            //SqlCommand komut2 = new SqlCommand("Select Hesap_Bakiyesi,Hesap_KulBakiye From Tbl_Hesaplar where Musteri_Numarasi=@p1 and Hesap_Numarasi=@p2", bgl.baglanti());
            //komut2.Parameters.AddWithValue("@p1", MusteriNo);
            //komut2.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    LblBakiye.Text = dr2[0].ToString();
            //    LblKulBakiye.Text = dr2[1].ToString();
            //}
            bakiyeListele(); //her seçimde bakiyeyi listeledik 
            gunlukLimitListele();//her seçimde günlük limiti listeledik
            
            //burada gunluklimiti kontrol ettik günlük limit hiç cekilmemiş ise gidip yazdık TODO
            if (string.IsNullOrEmpty(lblGunlukLimit.Text))
            {
                lblGunlukLimit.Text = 0.ToString();
            } 

        }

        private void BtnParaCek_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCekMiktar.Text))
            {
                MessageBox.Show("Lütfen miktar giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(CmbHesapNo.Text))
            {
                MessageBox.Show("Lütfen hesap seçiniz");
                return;
            }

            decimal cekilen;
            cekilen = Convert.ToDecimal(TxtCekMiktar.Text);

            decimal bakiye, kbakiye;
            bakiye = Convert.ToDecimal(LblBakiye.Text);
            kbakiye = Convert.ToDecimal(LblKulBakiye.Text);

            decimal gunlukLimit;
            gunlukLimit = Convert.ToDecimal(lblGunlukLimit.Text);

            decimal limitCekilenToplam;
            limitCekilenToplam = cekilen + gunlukLimit;

            //label1.Text = gunlukLimit.ToString();
            //label2.Text = limitCekilenToplam.ToString();           

            if (gunlukLimit < 750 && limitCekilenToplam < 751)

            {

                if (bakiye > 0 && kbakiye > 0 && cekilen < bakiye && cekilen < kbakiye)
                {
                    SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi-@p1,Hesap_KulBakiye=Hesap_KulBakiye-@p1 where Hesap_Numarasi=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", cekilen.ToString());
                    komut.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
                    komut.ExecuteNonQuery();

                    islemekle(cekilen);//islem tablosuna yaz
                    bakiyeListele();//yeni bakiyeyi miktarını yazdık
                    gunlukLimitListele(); //gunluk limiti yeniledik

                    bgl.baglanti().Close();
                    //MessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + cekilen.ToString() + "çekildi", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(string.Concat(CmbHesapNo.Text, " No'lu hesabtan ", cekilen.ToString(), " çekildi."), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Show();
                }

                else if (kbakiye <= 0 || cekilen >= kbakiye)
                {
                    XtraMessageBox.Show("Kullanılabilir bakiye yetersiz Çekim Yapılmaz");
                }

                else
                {
                    XtraMessageBox.Show("Yetersiz bakiye çekim Yapılmaz");
                }

            }
            else
            {
                XtraMessageBox.Show("Günlük Limiti aştınız para çekemezsiniz");
            }




        }

        private void TxtParaYatir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtYatirTutar.Text))
            {
                MessageBox.Show("Lütfen miktar giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(CmbHesapNo.Text))
            {
                MessageBox.Show("Lütfen hesap seçiniz");
                return;
            }

            decimal yatirilan;
            yatirilan = Convert.ToDecimal(TxtYatirTutar.Text);
            SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi+@p1,Hesap_KulBakiye=Hesap_KulBakiye+@p1 where Hesap_Numarasi=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", yatirilan.ToString());
            komut.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
            komut.ExecuteNonQuery();

            islemekle(yatirilan);//islem tablosuna yaz
            bakiyeListele();//yeni bakiyeyi miktarını yazdık

            bgl.baglanti().Close();
            XtraMessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + yatirilan.ToString() + "yatırıldı", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void BtnHavale_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtHaveleMiktar.Text))
            {
                MessageBox.Show("Lütfen miktar giriniz");
                return;
            }

            decimal yatirilan;
            yatirilan = Convert.ToDecimal(TxtHaveleMiktar.Text);
            mukerrer();
            if (durum == false && CmbHesapNo.Text != "")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi+@p1,Hesap_KulBakiye=Hesap_KulBakiye+@p1 where Hesap_Numarasi=@p2 update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi-@p1,Hesap_KulBakiye=Hesap_KulBakiye-@p1 where Hesap_Numarasi=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", yatirilan.ToString());
                komut.Parameters.AddWithValue("@p2", TxtHavaleHesap.Text);
                komut.Parameters.AddWithValue("@p3", CmbHesapNo.Text);
                komut.ExecuteNonQuery();

                islemekle(yatirilan);//islem tablosuna yaz
                bakiyeListele();//yeni bakiyeyi miktarını yazdık

                bgl.baglanti().Close();
                XtraMessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + TxtHavaleHesap.Text + " No'lu hesaba " + yatirilan.ToString() + "yatırıldı", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Lütfen hesap numaranızı veya gönderilecek hesap numarasını kontrol ediniz");
            }



        }    

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double dolarkuru = 8.54;
                double trkuru = 0.12;

                string kursecim1 = cmbSecim1.Text;
                string kursecim2 = cmbSecim2.Text;

                if (string.IsNullOrWhiteSpace(txtGiris.Text))
                {
                    MessageBox.Show("Lütfen sayı giriniz");
                    return;
                }
                double kurgiris = Convert.ToDouble(txtGiris.Text);
                //double sayi2 = Convert.ToDouble(txtSonuc.Text);
                if (kursecim1 == "USD" && kursecim2 == "TRY")
                {
                    txtSonuc.Text = dolarkuru * kurgiris + "";
                }
                if (kursecim1 == "TRY" && kursecim2 == "USD")
                {
                    txtSonuc.Text = trkuru * kurgiris + "";
                }
                if (kursecim1 == "USD" && kursecim2 == "USD")
                {
                    txtSonuc.Text = txtGiris.Text;
                }
                if (kursecim1 == "TRY" && kursecim2 == "TRY")
                {
                    txtSonuc.Text = txtGiris.Text;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }

        private void barWorkspaceMenuItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            LblTurIslem.Text = 3.ToString();
            panelParaIslemleri.Visible = true;
            panelKur.Visible = false;
            panelRapor.Visible = false;
        }

        private void barKurHesapla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelKur.Visible = true;
            panelParaIslemleri.Visible = false;
            panelRapor.Visible = false;
        }

        private void barParaYatir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            tabControl1.SelectedIndex = 1;
            LblTurIslem.Text = 2.ToString();
            panelParaIslemleri.Visible = true;
            panelKur.Visible = false;
            panelRapor.Visible = false;
        }

        private void barHavale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            LblTurIslem.Text = 1.ToString();           
            panelParaIslemleri.Visible = true;
            panelKur.Visible = false;
            panelRapor.Visible = false;
        }

        private void barHesapOzeti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelRapor.Visible = true;
            panelParaIslemleri.Visible = false;
            panelKur.Visible = false;
            
        }

        private void BtnOzetle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateSecim1.Text.ToString())) // || string.IsNullOrWhiteSpace(dateEdit2.EditValue.ToString())
            {
                MessageBox.Show("Lütfen tarih 1 seçimini kontrol ediniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(dateSecim2.Text.ToString()))
            {
                MessageBox.Show("Lütfen tarih 2 seçimini kontrol ediniz");
                return;
            }

            string date1, date2;

            date1 = dateSecim1.EditValue.ToString();
            date2 = dateSecim2.EditValue.ToString();

            lblTarih1.Text = date1;
            lblTarih2.Text = date2;


            //SqlCommand komut = new SqlCommand("Select * from Tbl_Islemler where Musteri_Numarasi=@p1", bgl.baglanti());
            SqlCommand komut = new SqlCommand("Select * from Tbl_Islemler where Islem_Tarihi BETWEEN @p1 and @p2 and Musteri_Numarasi=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", date1);
            komut.Parameters.AddWithValue("@p2", date2);
            komut.Parameters.AddWithValue("@p3", MusteriNo);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable(); //datatable oluşturduk
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

       
    }
}
