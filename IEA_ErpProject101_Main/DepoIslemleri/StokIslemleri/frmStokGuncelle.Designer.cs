
namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    partial class frmStokGuncelle
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
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenelNo = new System.Windows.Forms.TextBox();
            this.txtUt = new System.Windows.Forms.DateTimePicker();
            this.txtSkt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(12, 88);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(145, 22);
            this.txtUrunKodu.TabIndex = 0;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(163, 88);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(145, 22);
            this.txtLot.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(314, 88);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(145, 22);
            this.txtBarkod.TabIndex = 0;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(465, 88);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(145, 22);
            this.txtAdet.TabIndex = 0;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(879, 88);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(145, 22);
            this.txtAlisFiyat.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Urun Kodu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(163, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lot/Seri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(314, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(465, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(876, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alis Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenelNo
            // 
            this.txtGenelNo.Location = new System.Drawing.Point(15, 12);
            this.txtGenelNo.Name = "txtGenelNo";
            this.txtGenelNo.Size = new System.Drawing.Size(145, 22);
            this.txtGenelNo.TabIndex = 0;
            // 
            // txtUt
            // 
            this.txtUt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtUt.Location = new System.Drawing.Point(616, 88);
            this.txtUt.Name = "txtUt";
            this.txtUt.Size = new System.Drawing.Size(125, 22);
            this.txtUt.TabIndex = 5;
            // 
            // txtSkt
            // 
            this.txtSkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSkt.Location = new System.Drawing.Point(748, 88);
            this.txtSkt.Name = "txtSkt";
            this.txtSkt.Size = new System.Drawing.Size(125, 22);
            this.txtSkt.TabIndex = 6;
            this.txtSkt.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(613, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "UT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(747, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "SKT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStokGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 138);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSkt);
            this.Controls.Add(this.txtUt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGenelNo);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.txtUrunKodu);
            this.Name = "frmStokGuncelle";
            this.Text = "frmStokGuncelle";
            this.Load += new System.EventHandler(this.frmStokGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUrunKodu;
        public System.Windows.Forms.TextBox txtLot;
        public System.Windows.Forms.TextBox txtBarkod;
        public System.Windows.Forms.TextBox txtAdet;
        public System.Windows.Forms.TextBox txtAlisFiyat;
        public System.Windows.Forms.TextBox txtGenelNo;
        private System.Windows.Forms.DateTimePicker txtUt;
        private System.Windows.Forms.DateTimePicker txtSkt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}