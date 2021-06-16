
namespace Banka_Otomasyonu
{
    partial class FrmKullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grpKullaniciIslemleri = new DevExpress.XtraEditors.GroupControl();
            this.txtKullaniciSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKullaniciIslemleri)).BeginInit();
            this.grpKullaniciIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İsim Soyisim:";
            // 
            // txtKullaniciAdSoyad
            // 
            this.txtKullaniciAdSoyad.Location = new System.Drawing.Point(90, 32);
            this.txtKullaniciAdSoyad.Name = "txtKullaniciAdSoyad";
            this.txtKullaniciAdSoyad.Size = new System.Drawing.Size(333, 20);
            this.txtKullaniciAdSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(90, 58);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(333, 20);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(90, 84);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(333, 20);
            this.txtKullaniciSifre.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Şifre:";
            // 
            // txtKullaniciEmail
            // 
            this.txtKullaniciEmail.Location = new System.Drawing.Point(90, 110);
            this.txtKullaniciEmail.Name = "txtKullaniciEmail";
            this.txtKullaniciEmail.Size = new System.Drawing.Size(333, 20);
            this.txtKullaniciEmail.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Email";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(332, 136);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(91, 23);
            this.btnKullaniciEkle.TabIndex = 8;
            this.btnKullaniciEkle.Text = "Ekle";
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // grpKullaniciIslemleri
            // 
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciSil);
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciGuncelle);
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciSifre);
            this.grpKullaniciIslemleri.Controls.Add(this.btnKullaniciEkle);
            this.grpKullaniciIslemleri.Controls.Add(this.labelControl1);
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciEmail);
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciAdSoyad);
            this.grpKullaniciIslemleri.Controls.Add(this.labelControl4);
            this.grpKullaniciIslemleri.Controls.Add(this.labelControl2);
            this.grpKullaniciIslemleri.Controls.Add(this.txtKullaniciAdi);
            this.grpKullaniciIslemleri.Controls.Add(this.labelControl3);
            this.grpKullaniciIslemleri.Location = new System.Drawing.Point(12, 29);
            this.grpKullaniciIslemleri.Name = "grpKullaniciIslemleri";
            this.grpKullaniciIslemleri.Size = new System.Drawing.Size(428, 165);
            this.grpKullaniciIslemleri.TabIndex = 9;
            this.grpKullaniciIslemleri.Text = "Kullanici İşlemleri";
            // 
            // txtKullaniciSil
            // 
            this.txtKullaniciSil.Location = new System.Drawing.Point(90, 136);
            this.txtKullaniciSil.Name = "txtKullaniciSil";
            this.txtKullaniciSil.Size = new System.Drawing.Size(91, 23);
            this.txtKullaniciSil.TabIndex = 10;
            this.txtKullaniciSil.Text = "Sil";
            this.txtKullaniciSil.Click += new System.EventHandler(this.txtKullaniciSil_Click);
            // 
            // txtKullaniciGuncelle
            // 
            this.txtKullaniciGuncelle.Location = new System.Drawing.Point(211, 136);
            this.txtKullaniciGuncelle.Name = "txtKullaniciGuncelle";
            this.txtKullaniciGuncelle.Size = new System.Drawing.Size(91, 23);
            this.txtKullaniciGuncelle.TabIndex = 9;
            this.txtKullaniciGuncelle.Text = "Güncelle";
            this.txtKullaniciGuncelle.Visible = false;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpKullaniciIslemleri);
            this.Name = "FrmKullanici";
            this.Text = "Kullanici Formu";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKullaniciIslemleri)).EndInit();
            this.grpKullaniciIslemleri.ResumeLayout(false);
            this.grpKullaniciIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdSoyad;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKullaniciEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciEkle;
        private DevExpress.XtraEditors.GroupControl grpKullaniciIslemleri;
        private DevExpress.XtraEditors.SimpleButton txtKullaniciSil;
        private DevExpress.XtraEditors.SimpleButton txtKullaniciGuncelle;
    }
}