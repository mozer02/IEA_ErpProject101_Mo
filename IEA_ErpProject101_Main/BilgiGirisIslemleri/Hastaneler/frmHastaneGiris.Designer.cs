
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler
{
    partial class frmHastaneGiris
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYet1 = new System.Windows.Forms.TextBox();
            this.txtYet2 = new System.Windows.Forms.TextBox();
            this.txtYet3 = new System.Windows.Forms.TextBox();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.txtDepartman2 = new System.Windows.Forms.ComboBox();
            this.txtDepartman3 = new System.Windows.Forms.ComboBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtHastaneAdi = new System.Windows.Forms.TextBox();
            this.txtHastaneCari = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHastMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtYcep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastTel = new System.Windows.Forms.MaskedTextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1125, 58);
            this.pnlUst.TabIndex = 0;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(521, 14);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(172, 34);
            this.lblHastaneKodu.TabIndex = 1;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 530);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1125, 37);
            this.pnlAlt.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.CariMail,
            this.YetkiliAdi1});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 360);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1125, 170);
            this.Liste.TabIndex = 2;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 62;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Hastane Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 117;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Hastane Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Hastane Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 130;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Hastane Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 109;
            // 
            // YetkiliAdi1
            // 
            this.YetkiliAdi1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliAdi1.HeaderText = "Yetkili Kisi";
            this.YetkiliAdi1.MinimumWidth = 6;
            this.YetkiliAdi1.Name = "YetkiliAdi1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 350);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1125, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hastane Cari Adi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres1 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(531, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Adres2 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(362, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yetkili";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(286, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cari Tipi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(534, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departman";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label99.Location = new System.Drawing.Point(952, 10);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(169, 23);
            this.label99.TabIndex = 4;
            this.label99.Text = "E-Mail";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(720, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefon";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(835, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cep";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(14, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vergi Dairesi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYet1
            // 
            this.txtYet1.Location = new System.Drawing.Point(365, 37);
            this.txtYet1.Name = "txtYet1";
            this.txtYet1.Size = new System.Drawing.Size(163, 22);
            this.txtYet1.TabIndex = 10;
            // 
            // txtYet2
            // 
            this.txtYet2.Location = new System.Drawing.Point(365, 65);
            this.txtYet2.Name = "txtYet2";
            this.txtYet2.Size = new System.Drawing.Size(163, 22);
            this.txtYet2.TabIndex = 15;
            // 
            // txtYet3
            // 
            this.txtYet3.Location = new System.Drawing.Point(365, 93);
            this.txtYet3.Name = "txtYet3";
            this.txtYet3.Size = new System.Drawing.Size(163, 22);
            this.txtYet3.TabIndex = 20;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(534, 34);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(180, 24);
            this.txtDepartman1.TabIndex = 11;
            // 
            // txtDepartman2
            // 
            this.txtDepartman2.FormattingEnabled = true;
            this.txtDepartman2.Location = new System.Drawing.Point(534, 64);
            this.txtDepartman2.Name = "txtDepartman2";
            this.txtDepartman2.Size = new System.Drawing.Size(180, 24);
            this.txtDepartman2.TabIndex = 16;
            // 
            // txtDepartman3
            // 
            this.txtDepartman3.FormattingEnabled = true;
            this.txtDepartman3.Location = new System.Drawing.Point(534, 94);
            this.txtDepartman3.Name = "txtDepartman3";
            this.txtDepartman3.Size = new System.Drawing.Size(180, 24);
            this.txtDepartman3.TabIndex = 21;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(952, 92);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(169, 22);
            this.txtEmail3.TabIndex = 24;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(952, 64);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(169, 22);
            this.txtEmail2.TabIndex = 19;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(952, 36);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(169, 22);
            this.txtEmail1.TabIndex = 14;
            // 
            // txtHastaneAdi
            // 
            this.txtHastaneAdi.Location = new System.Drawing.Point(120, 39);
            this.txtHastaneAdi.Name = "txtHastaneAdi";
            this.txtHastaneAdi.Size = new System.Drawing.Size(227, 22);
            this.txtHastaneAdi.TabIndex = 0;
            // 
            // txtHastaneCari
            // 
            this.txtHastaneCari.Location = new System.Drawing.Point(120, 67);
            this.txtHastaneCari.Name = "txtHastaneCari";
            this.txtHastaneCari.Size = new System.Drawing.Size(227, 22);
            this.txtHastaneCari.TabIndex = 1;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(120, 151);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(408, 47);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(637, 127);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(484, 46);
            this.txtAdres2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(286, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Vergi No :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(120, 242);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(160, 22);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(14, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hastane Mail :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(14, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hastane Tel :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastMail
            // 
            this.txtHastMail.Location = new System.Drawing.Point(120, 123);
            this.txtHastMail.Name = "txtHastMail";
            this.txtHastMail.Size = new System.Drawing.Size(227, 22);
            this.txtHastMail.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(14, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Sehir :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(120, 204);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(160, 24);
            this.txtSehir.TabIndex = 6;
            this.txtSehir.SelectedIndexChanged += new System.EventHandler(this.txtSehir_SelectedIndexChanged);
            // 
            // txtYcep1
            // 
            this.txtYcep1.Location = new System.Drawing.Point(835, 36);
            this.txtYcep1.Mask = "(999) 000-0000";
            this.txtYcep1.Name = "txtYcep1";
            this.txtYcep1.Size = new System.Drawing.Size(111, 22);
            this.txtYcep1.TabIndex = 13;
            // 
            // txtYcep2
            // 
            this.txtYcep2.Location = new System.Drawing.Point(835, 64);
            this.txtYcep2.Mask = "(999) 000-0000";
            this.txtYcep2.Name = "txtYcep2";
            this.txtYcep2.Size = new System.Drawing.Size(111, 22);
            this.txtYcep2.TabIndex = 18;
            // 
            // txtYcep3
            // 
            this.txtYcep3.Location = new System.Drawing.Point(835, 92);
            this.txtYcep3.Mask = "(999) 000-0000";
            this.txtYcep3.Name = "txtYcep3";
            this.txtYcep3.Size = new System.Drawing.Size(111, 22);
            this.txtYcep3.TabIndex = 23;
            // 
            // txtYtel1
            // 
            this.txtYtel1.Location = new System.Drawing.Point(720, 36);
            this.txtYtel1.Mask = "(999) 000-0000";
            this.txtYtel1.Name = "txtYtel1";
            this.txtYtel1.Size = new System.Drawing.Size(109, 22);
            this.txtYtel1.TabIndex = 12;
            // 
            // txtYtel2
            // 
            this.txtYtel2.Location = new System.Drawing.Point(720, 64);
            this.txtYtel2.Mask = "(999) 000-0000";
            this.txtYtel2.Name = "txtYtel2";
            this.txtYtel2.Size = new System.Drawing.Size(109, 22);
            this.txtYtel2.TabIndex = 17;
            // 
            // txtYtel3
            // 
            this.txtYtel3.Location = new System.Drawing.Point(720, 92);
            this.txtYtel3.Mask = "(999) 000-0000";
            this.txtYtel3.Name = "txtYtel3";
            this.txtYtel3.Size = new System.Drawing.Size(109, 22);
            this.txtYtel3.TabIndex = 22;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(392, 243);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(136, 22);
            this.txtVnTc.TabIndex = 9;
            // 
            // txtHastTel
            // 
            this.txtHastTel.Location = new System.Drawing.Point(120, 95);
            this.txtHastTel.Mask = "(999) 000-0000";
            this.txtHastTel.Name = "txtHastTel";
            this.txtHastTel.Size = new System.Drawing.Size(160, 22);
            this.txtHastTel.TabIndex = 2;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtHastTel);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtYtel3);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.txtYcep3);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtYtel2);
            this.pnlOrta.Controls.Add(this.txtYtel1);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtYcep2);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtYcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.label99);
            this.pnlOrta.Controls.Add(this.txtHastMail);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtHastaneCari);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtHastaneAdi);
            this.pnlOrta.Controls.Add(this.txtYet1);
            this.pnlOrta.Controls.Add(this.txtEmail3);
            this.pnlOrta.Controls.Add(this.txtYet2);
            this.pnlOrta.Controls.Add(this.txtEmail2);
            this.pnlOrta.Controls.Add(this.txtYet3);
            this.pnlOrta.Controls.Add(this.txtEmail1);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.txtDepartman3);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.txtDepartman2);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 58);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1125, 292);
            this.pnlOrta.TabIndex = 20;
            this.pnlOrta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlOrta_Scroll);
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(392, 205);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(160, 24);
            this.txtCariTipi.TabIndex = 7;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(17, 10);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(330, 22);
            this.txtKayitBul.TabIndex = 26;
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(17, 3);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(65, 52);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(1058, 9);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(58, 39);
            this.btnFormCikis.TabIndex = 4;
            this.btnFormCikis.UseVisualStyleBackColor = true;
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(88, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(65, 52);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(159, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 52);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(230, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(65, 52);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmHastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 567);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmHastaneGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaneGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaneGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmHastaneGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYet1;
        private System.Windows.Forms.TextBox txtYet2;
        private System.Windows.Forms.TextBox txtYet3;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.ComboBox txtDepartman2;
        private System.Windows.Forms.ComboBox txtDepartman3;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtHastaneAdi;
        private System.Windows.Forms.TextBox txtHastaneCari;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHastMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtYcep1;
        private System.Windows.Forms.MaskedTextBox txtYcep2;
        private System.Windows.Forms.MaskedTextBox txtYcep3;
        private System.Windows.Forms.MaskedTextBox txtYtel1;
        private System.Windows.Forms.MaskedTextBox txtYtel2;
        private System.Windows.Forms.MaskedTextBox txtYtel3;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.MaskedTextBox txtHastTel;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliAdi1;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.TextBox txtKayitBul;
    }
}