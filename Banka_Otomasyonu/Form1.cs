using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
