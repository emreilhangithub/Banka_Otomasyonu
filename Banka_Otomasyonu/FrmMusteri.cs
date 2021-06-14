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

namespace Banka_Otomasyonu
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string MusteriNo;
        string islemtarihi = DateTime.Now.ToString(); //islem tarihi
        bool durum;//mukerrer kontrol

        void mukerrer()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hesaplar where Hesap_Numarasi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtHavaleHesap.Text);
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

        void islemekle()
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Islemler (Hesap_Numarasi,Islem_Turu,Islem_Tarihi,Musteri_Numarasi) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbHesapNo.Text);
            komut2.Parameters.AddWithValue("@p2", LblTurIslem.Text);
            komut2.Parameters.AddWithValue("@p3", islemtarihi);
            komut2.Parameters.AddWithValue("@p4", MusteriNo);
            komut2.ExecuteNonQuery();            
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

        private void BtnParaCek_Click(object sender, EventArgs e)
        {
            int cekilen;
            cekilen = Convert.ToInt16(TxtCekMiktar.Text);

            double bakiye,kbakiye;
            bakiye = Convert.ToDouble(LblBakiye.Text);
            kbakiye = Convert.ToDouble(LblKulBakiye.Text);           


            if (bakiye > 0 && kbakiye > 0)
            {
                SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi-@p1,Hesap_KulBakiye=Hesap_KulBakiye-@p1 where Hesap_Numarasi=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", cekilen.ToString());
                komut.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
                komut.ExecuteNonQuery();

                islemekle();//islem tablosuna yaz

                bgl.baglanti().Close();
                MessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + cekilen.ToString() + "çekildi", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }

            else if (kbakiye <= 0)
            {
                MessageBox.Show("Kullanılabilir bakiye yetersiz Çekim Yapılmaz");
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye çekim Yapılmaz");
            }


           

        }

        private void TxtParaYatir_Click(object sender, EventArgs e)
        {
            int yatirilan;
            yatirilan = Convert.ToInt16(TxtYatirTutar.Text);
            SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi+@p1,Hesap_KulBakiye=Hesap_KulBakiye+@p1 where Hesap_Numarasi=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", yatirilan.ToString());
            komut.Parameters.AddWithValue("@p2", CmbHesapNo.Text);
            komut.ExecuteNonQuery();

            islemekle();//islem tablosuna yaz

            bgl.baglanti().Close();
            MessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + yatirilan.ToString() + "yatırıldı", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void BtnHavale_Click(object sender, EventArgs e)
        {
            int yatirilan;
            yatirilan = Convert.ToInt16(TxtHaveleMiktar.Text);
            mukerrer();
            if (durum == false && CmbHesapNo.Text != "")
            {               
                SqlCommand komut = new SqlCommand("update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi+@p1,Hesap_KulBakiye=Hesap_KulBakiye+@p1 where Hesap_Numarasi=@p2 update Tbl_Hesaplar set Hesap_Bakiyesi=Hesap_Bakiyesi-@p1,Hesap_KulBakiye=Hesap_KulBakiye-@p1 where Hesap_Numarasi=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", yatirilan.ToString());
                komut.Parameters.AddWithValue("@p2", TxtHavaleHesap.Text);
                komut.Parameters.AddWithValue("@p3", CmbHesapNo.Text);
                komut.ExecuteNonQuery();

                islemekle();//islem tablosuna yaz

                bgl.baglanti().Close();
                MessageBox.Show(CmbHesapNo.Text + " No'lu hesabtan " + TxtHavaleHesap.Text + " No'lu hesaba " + yatirilan.ToString() + "yatırıldı", " Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
            else
            {
                MessageBox.Show("Lütfen hesap numaranızı veya gönderilecek hesap numarasını kontrol ediniz");
            }
            
            
           
        }

        private void BtnOzetle_Click(object sender, EventArgs e)
        {
            //label2.Text = dateTimePicker1.Value.ToString();
            //label3.Text = dateEdit1.EditValue.ToString();

            SqlCommand komut = new SqlCommand("Select * from Tbl_Islemler where Musteri_Numarasi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MusteriNo);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable(); //datatable oluşturduk
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
    }
}
