
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    partial class frmDoktorGiris
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
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDCep1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDMail = new System.Windows.Forms.TextBox();
            this.txtDokMuaAdres2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDokHastAdres1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtDAdi = new System.Windows.Forms.TextBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtDUnvan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(17, 10);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(330, 22);
            this.txtKayitBul.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDTel
            // 
            this.txtDTel.Location = new System.Drawing.Point(120, 94);
            this.txtDTel.Mask = "(999) 000-0000";
            this.txtDTel.Name = "txtDTel";
            this.txtDTel.Size = new System.Drawing.Size(160, 22);
            this.txtDTel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(397, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 47);
            this.label5.TabIndex = 25;
            this.label5.Text = "Doktor Muayene Adres :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(392, 243);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(136, 22);
            this.txtVnTc.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(14, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Doktor Mail :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(420, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doktor Hast Adres :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDCep1
            // 
            this.txtDCep1.Location = new System.Drawing.Point(120, 122);
            this.txtDCep1.Mask = "(999) 000-0000";
            this.txtDCep1.Name = "txtDCep1";
            this.txtDCep1.Size = new System.Drawing.Size(160, 22);
            this.txtDCep1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(14, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departman";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(120, 242);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(160, 22);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(14, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Doktor Tel :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDMail
            // 
            this.txtDMail.Location = new System.Drawing.Point(120, 146);
            this.txtDMail.Name = "txtDMail";
            this.txtDMail.Size = new System.Drawing.Size(227, 22);
            this.txtDMail.TabIndex = 3;
            // 
            // txtDokMuaAdres2
            // 
            this.txtDokMuaAdres2.Location = new System.Drawing.Point(526, 66);
            this.txtDokMuaAdres2.Multiline = true;
            this.txtDokMuaAdres2.Name = "txtDokMuaAdres2";
            this.txtDokMuaAdres2.Size = new System.Drawing.Size(383, 46);
            this.txtDokMuaAdres2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(12, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cep";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDokHastAdres1
            // 
            this.txtDokHastAdres1.Location = new System.Drawing.Point(526, 10);
            this.txtDokHastAdres1.Multiline = true;
            this.txtDokHastAdres1.Name = "txtDokHastAdres1";
            this.txtDokHastAdres1.Size = new System.Drawing.Size(383, 47);
            this.txtDokHastAdres1.TabIndex = 4;
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
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(120, 174);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(227, 24);
            this.txtDepartman1.TabIndex = 11;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtDTel);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtDCep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtDMail);
            this.pnlOrta.Controls.Add(this.txtDokMuaAdres2);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtDokHastAdres1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtDAdi);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.txtDUnvan);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 58);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(930, 292);
            this.pnlOrta.TabIndex = 25;
            // 
            // txtDAdi
            // 
            this.txtDAdi.Location = new System.Drawing.Point(120, 66);
            this.txtDAdi.Name = "txtDAdi";
            this.txtDAdi.Size = new System.Drawing.Size(227, 22);
            this.txtDAdi.TabIndex = 0;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(392, 205);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(160, 24);
            this.txtCariTipi.TabIndex = 7;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(120, 204);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(160, 24);
            this.txtSehir.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 350);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(930, 10);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(424, 14);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(172, 34);
            this.lblHastaneKodu.TabIndex = 1;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Cep,
            this.CariMail});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 360);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(930, 170);
            this.Liste.TabIndex = 23;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 530);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(930, 37);
            this.pnlAlt.TabIndex = 22;
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
            this.pnlUst.Size = new System.Drawing.Size(930, 58);
            this.pnlUst.TabIndex = 21;
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
            this.btnFormCikis.Location = new System.Drawing.Point(863, 9);
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
            // txtDUnvan
            // 
            this.txtDUnvan.FormattingEnabled = true;
            this.txtDUnvan.Location = new System.Drawing.Point(120, 37);
            this.txtDUnvan.Name = "txtDUnvan";
            this.txtDUnvan.Size = new System.Drawing.Size(160, 24);
            this.txtDUnvan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.CariKodu.HeaderText = "Doktor Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 116;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Doktor Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Doktor Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 131;
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Doktor Gsm";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.Width = 112;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Doktor Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 108;
            // 
            // frmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 567);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmDoktorGiris";
            this.Text = "frmDoktorGiris";
            this.Load += new System.EventHandler(this.frmDoktorGiris_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDCep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDMail;
        private System.Windows.Forms.TextBox txtDokMuaAdres2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDokHastAdres1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.TextBox txtDAdi;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtDUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
    }
}