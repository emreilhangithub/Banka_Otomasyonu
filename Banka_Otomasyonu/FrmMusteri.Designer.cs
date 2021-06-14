
namespace Banka_Otomasyonu
{
    partial class FrmMusteri
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
            this.LblMusNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHavale = new System.Windows.Forms.TabPage();
            this.BtnHavale = new DevExpress.XtraEditors.SimpleButton();
            this.TxtHaveleMiktar = new DevExpress.XtraEditors.TextEdit();
            this.TxtHavaleHesap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tabParaYatir = new System.Windows.Forms.TabPage();
            this.TxtParaYatir = new DevExpress.XtraEditors.SimpleButton();
            this.TxtYatirTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tabParaÇek = new System.Windows.Forms.TabPage();
            this.BtnParaCek = new DevExpress.XtraEditors.SimpleButton();
            this.TxtCekMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CmbHesapNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LblBakiye = new DevExpress.XtraEditors.LabelControl();
            this.LblKulBakiye = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LblTurIslem = new DevExpress.XtraEditors.TextEdit();
            this.BtnOzetle = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1.SuspendLayout();
            this.tabHavale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHaveleMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHavaleHesap.Properties)).BeginInit();
            this.tabParaYatir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYatirTutar.Properties)).BeginInit();
            this.tabParaÇek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTurIslem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMusNo
            // 
            this.LblMusNo.Location = new System.Drawing.Point(576, 22);
            this.LblMusNo.Name = "LblMusNo";
            this.LblMusNo.Size = new System.Drawing.Size(42, 13);
            this.LblMusNo.TabIndex = 0;
            this.LblMusNo.Text = "0000000";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(488, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müşteri Numarası";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHavale);
            this.tabControl1.Controls.Add(this.tabParaYatir);
            this.tabControl1.Controls.Add(this.tabParaÇek);
            this.tabControl1.Location = new System.Drawing.Point(24, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 176);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabHavale
            // 
            this.tabHavale.Controls.Add(this.BtnHavale);
            this.tabHavale.Controls.Add(this.TxtHaveleMiktar);
            this.tabHavale.Controls.Add(this.TxtHavaleHesap);
            this.tabHavale.Controls.Add(this.labelControl18);
            this.tabHavale.Controls.Add(this.labelControl17);
            this.tabHavale.Controls.Add(this.labelControl16);
            this.tabHavale.Controls.Add(this.labelControl15);
            this.tabHavale.Controls.Add(this.labelControl14);
            this.tabHavale.Controls.Add(this.labelControl2);
            this.tabHavale.Location = new System.Drawing.Point(4, 22);
            this.tabHavale.Name = "tabHavale";
            this.tabHavale.Padding = new System.Windows.Forms.Padding(3);
            this.tabHavale.Size = new System.Drawing.Size(619, 150);
            this.tabHavale.TabIndex = 0;
            this.tabHavale.Text = "Havale";
            this.tabHavale.UseVisualStyleBackColor = true;
            // 
            // BtnHavale
            // 
            this.BtnHavale.Location = new System.Drawing.Point(337, 120);
            this.BtnHavale.Name = "BtnHavale";
            this.BtnHavale.Size = new System.Drawing.Size(75, 23);
            this.BtnHavale.TabIndex = 17;
            this.BtnHavale.Text = "Havale Et";
            this.BtnHavale.Click += new System.EventHandler(this.BtnHavale_Click);
            // 
            // TxtHaveleMiktar
            // 
            this.TxtHaveleMiktar.Location = new System.Drawing.Point(312, 94);
            this.TxtHaveleMiktar.Name = "TxtHaveleMiktar";
            this.TxtHaveleMiktar.Size = new System.Drawing.Size(100, 20);
            this.TxtHaveleMiktar.TabIndex = 16;
            // 
            // TxtHavaleHesap
            // 
            this.TxtHavaleHesap.Location = new System.Drawing.Point(312, 56);
            this.TxtHavaleHesap.Name = "TxtHavaleHesap";
            this.TxtHavaleHesap.Size = new System.Drawing.Size(100, 20);
            this.TxtHavaleHesap.TabIndex = 15;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(183, 97);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(33, 13);
            this.labelControl18.TabIndex = 14;
            this.labelControl18.Text = "Miktar:";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(183, 59);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(50, 13);
            this.labelControl17.TabIndex = 13;
            this.labelControl17.Text = "Hesap No:";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(47, 81);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(125, 13);
            this.labelControl16.TabIndex = 12;
            this.labelControl16.Text = "Aktarmak İstediginiz Tutar";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(50, 42);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(123, 13);
            this.labelControl15.TabIndex = 11;
            this.labelControl15.Text = "Paranın Yatırılacağı Hesap";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Location = new System.Drawing.Point(0, 22);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(535, 10);
            this.labelControl14.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(512, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 29);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Para Aktarma Havale";
            // 
            // tabParaYatir
            // 
            this.tabParaYatir.Controls.Add(this.TxtParaYatir);
            this.tabParaYatir.Controls.Add(this.TxtYatirTutar);
            this.tabParaYatir.Controls.Add(this.labelControl19);
            this.tabParaYatir.Controls.Add(this.labelControl20);
            this.tabParaYatir.Controls.Add(this.labelControl12);
            this.tabParaYatir.Controls.Add(this.labelControl10);
            this.tabParaYatir.Location = new System.Drawing.Point(4, 22);
            this.tabParaYatir.Name = "tabParaYatir";
            this.tabParaYatir.Padding = new System.Windows.Forms.Padding(3);
            this.tabParaYatir.Size = new System.Drawing.Size(619, 150);
            this.tabParaYatir.TabIndex = 1;
            this.tabParaYatir.Text = "Para Yatırma";
            this.tabParaYatir.UseVisualStyleBackColor = true;
            // 
            // TxtParaYatir
            // 
            this.TxtParaYatir.Location = new System.Drawing.Point(320, 102);
            this.TxtParaYatir.Name = "TxtParaYatir";
            this.TxtParaYatir.Size = new System.Drawing.Size(75, 23);
            this.TxtParaYatir.TabIndex = 21;
            this.TxtParaYatir.Text = "Para Yatır";
            this.TxtParaYatir.Click += new System.EventHandler(this.TxtParaYatir_Click);
            // 
            // TxtYatirTutar
            // 
            this.TxtYatirTutar.Location = new System.Drawing.Point(295, 76);
            this.TxtYatirTutar.Name = "TxtYatirTutar";
            this.TxtYatirTutar.Size = new System.Drawing.Size(100, 20);
            this.TxtYatirTutar.TabIndex = 20;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(166, 79);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(33, 13);
            this.labelControl19.TabIndex = 19;
            this.labelControl19.Text = "Miktar:";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(30, 63);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(121, 13);
            this.labelControl20.TabIndex = 18;
            this.labelControl20.Text = "Yatırmak İstediginiz Tutar";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(0, 23);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(555, 10);
            this.labelControl12.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(553, 6);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 27);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Para Yatırma";
            // 
            // tabParaÇek
            // 
            this.tabParaÇek.Controls.Add(this.BtnParaCek);
            this.tabParaÇek.Controls.Add(this.TxtCekMiktar);
            this.tabParaÇek.Controls.Add(this.labelControl21);
            this.tabParaÇek.Controls.Add(this.labelControl22);
            this.tabParaÇek.Controls.Add(this.labelControl13);
            this.tabParaÇek.Controls.Add(this.labelControl11);
            this.tabParaÇek.Location = new System.Drawing.Point(4, 22);
            this.tabParaÇek.Name = "tabParaÇek";
            this.tabParaÇek.Padding = new System.Windows.Forms.Padding(3);
            this.tabParaÇek.Size = new System.Drawing.Size(619, 150);
            this.tabParaÇek.TabIndex = 2;
            this.tabParaÇek.Text = "Para Çekme";
            this.tabParaÇek.UseVisualStyleBackColor = true;
            // 
            // BtnParaCek
            // 
            this.BtnParaCek.Location = new System.Drawing.Point(320, 93);
            this.BtnParaCek.Name = "BtnParaCek";
            this.BtnParaCek.Size = new System.Drawing.Size(75, 23);
            this.BtnParaCek.TabIndex = 25;
            this.BtnParaCek.Text = "Para Çek";
            this.BtnParaCek.Click += new System.EventHandler(this.BtnParaCek_Click);
            // 
            // TxtCekMiktar
            // 
            this.TxtCekMiktar.Location = new System.Drawing.Point(295, 67);
            this.TxtCekMiktar.Name = "TxtCekMiktar";
            this.TxtCekMiktar.Size = new System.Drawing.Size(100, 20);
            this.TxtCekMiktar.TabIndex = 24;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(166, 70);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(33, 13);
            this.labelControl21.TabIndex = 23;
            this.labelControl21.Text = "Miktar:";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(30, 54);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(117, 13);
            this.labelControl22.TabIndex = 22;
            this.labelControl22.Text = "Çekmek İstediginiz Tutar";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseBackColor = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(0, 19);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(566, 10);
            this.labelControl13.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(561, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(55, 26);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Para Çekme";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tabControl1);
            this.panelControl1.Location = new System.Drawing.Point(2, 97);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(656, 198);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Hesap:";
            // 
            // CmbHesapNo
            // 
            this.CmbHesapNo.Location = new System.Drawing.Point(52, 71);
            this.CmbHesapNo.Name = "CmbHesapNo";
            this.CmbHesapNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbHesapNo.Size = new System.Drawing.Size(100, 20);
            this.CmbHesapNo.TabIndex = 3;
            this.CmbHesapNo.SelectedIndexChanged += new System.EventHandler(this.CmbHesapNo_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(201, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Bakiye";
            // 
            // LblBakiye
            // 
            this.LblBakiye.Location = new System.Drawing.Point(250, 74);
            this.LblBakiye.Name = "LblBakiye";
            this.LblBakiye.Size = new System.Drawing.Size(12, 13);
            this.LblBakiye.TabIndex = 5;
            this.LblBakiye.Text = "0₺";
            // 
            // LblKulBakiye
            // 
            this.LblKulBakiye.Location = new System.Drawing.Point(422, 74);
            this.LblKulBakiye.Name = "LblKulBakiye";
            this.LblKulBakiye.Size = new System.Drawing.Size(12, 13);
            this.LblKulBakiye.TabIndex = 7;
            this.LblKulBakiye.Text = "0₺";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(328, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Kullanılabilir Bakiye";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "İşlemler:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(526, 44);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "İşlem Tür";
            // 
            // LblTurIslem
            // 
            this.LblTurIslem.EditValue = "1";
            this.LblTurIslem.Enabled = false;
            this.LblTurIslem.Location = new System.Drawing.Point(576, 41);
            this.LblTurIslem.Name = "LblTurIslem";
            this.LblTurIslem.Size = new System.Drawing.Size(42, 20);
            this.LblTurIslem.TabIndex = 10;
            // 
            // BtnOzetle
            // 
            this.BtnOzetle.Location = new System.Drawing.Point(328, 301);
            this.BtnOzetle.Name = "BtnOzetle";
            this.BtnOzetle.Size = new System.Drawing.Size(75, 23);
            this.BtnOzetle.TabIndex = 11;
            this.BtnOzetle.Text = "Özetle";
            this.BtnOzetle.Click += new System.EventHandler(this.BtnOzetle_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(101, 303);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 12;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(207, 303);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 342);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(666, 102);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 448);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.BtnOzetle);
            this.Controls.Add(this.LblTurIslem);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.LblKulBakiye);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.LblBakiye);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.CmbHesapNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LblMusNo);
            this.Name = "FrmMusteri";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHavale.ResumeLayout(false);
            this.tabHavale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHaveleMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHavaleHesap.Properties)).EndInit();
            this.tabParaYatir.ResumeLayout(false);
            this.tabParaYatir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYatirTutar.Properties)).EndInit();
            this.tabParaÇek.ResumeLayout(false);
            this.tabParaÇek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmbHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTurIslem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblMusNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHavale;
        private System.Windows.Forms.TabPage tabParaYatir;
        private System.Windows.Forms.TabPage tabParaÇek;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit CmbHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LblBakiye;
        private DevExpress.XtraEditors.LabelControl LblKulBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit LblTurIslem;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton BtnHavale;
        private DevExpress.XtraEditors.TextEdit TxtHaveleMiktar;
        private DevExpress.XtraEditors.TextEdit TxtHavaleHesap;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton TxtParaYatir;
        private DevExpress.XtraEditors.TextEdit TxtYatirTutar;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.SimpleButton BtnParaCek;
        private DevExpress.XtraEditors.TextEdit TxtCekMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.SimpleButton BtnOzetle;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}