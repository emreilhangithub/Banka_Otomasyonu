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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (radioGroup1.SelectedIndex == 0)
            {
                LblKullaniciAdi.Visible = false;
                TxtKullaniciAdi.Visible = false;
                LnkSifre.Visible = false;
                LblMusteri.Text = "Müşteri No:";
            }

            if (radioGroup1.SelectedIndex == 1)
            {
                LblKullaniciAdi.Visible = true;
                TxtKullaniciAdi.Visible = true;
                LnkSifre.Visible = true;
                LblMusteri.Text = "Şifre";
            }
            
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_Musteriler where Musteri_Numarasi=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtMusteri.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    FrmMusteri fm = new FrmMusteri();
                    this.Hide();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Müşteri Numanızı Kontrol Ediniz");
                }
                bgl.baglanti().Close();
               
            }

            if (radioGroup1.SelectedIndex == 1)
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_Kullanicilar where Kullanici_Adi=@p1 and Kullanici_Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtMusteri.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {                    
                    FrmKullanici fk = new FrmKullanici();
                    this.Hide();
                    fk.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre");
                }
                bgl.baglanti().Close();
               
            }
        }

        private void radioGroup1_Click(object sender, EventArgs e)
        {
           
        }

        private void LinkSifre_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = true;
        }

        private void Lnkİptal_Click(object sender, EventArgs e)
        {
            groupControl2.Visible = false;
            groupControl1.Visible = true;            
        }
    }
}
