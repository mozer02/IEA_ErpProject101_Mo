using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;

namespace IEA_ErpProject101_Main.UrunIslemleri
{
    public partial class frmUrunGiris : Ortaklar
    {
        //private ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();

        private int secimId = -1;

        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblUrunler
                       where s.isActive==true
                select s).ToList();

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblFirmaKodu.Text = n.UrunGenelKodu();
            txtKayitBul.Text = n.UrunGenelKodu();
        }

        private void ComboDoldur()
        {
            txtUrunTedarikciId.DataSource = (from s in db.tblCariler
                                             where s.CariGroupId == 3
                                             where s.CariUnvan == "Distributor"
                                             select s).ToList();
            txtUrunTedarikciId.ValueMember = "Id";
            txtUrunTedarikciId.DisplayMember = "CariAdi";
            txtUrunTedarikciId.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            if (secimId!=-1 || txtUKodu.Text=="" || txtKullanimAy.Text=="")
            {
                MessageBox.Show("Urun kodu veya Kullanim suresi bos birakilamaz... yada kaydi yapilmis urunler tekrar kaydedilemez.");
                return;
            }
            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdi = txtUAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatis.Text);
                urn.KutuIcerik = txtUKutuIcerik.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunAciklama = txtUAciklama.Text;
                urn.KullanimSuresiAy = (int)txtKullanimAy.Value;
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;
                

                db.tblUrunler.Add(urn);
                db.SaveChanges();

                MessageBox.Show("Kayit basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }

            secimId = -1;
        }

         private tblUrunler urunler;
        public void Ac(int id)
        {
            secimId = id;
            urunler = db.tblUrunler.Find(secimId);
            
            try
            {
                tblUrunler urn = urunler;
                txtUrunTedarikciId.Text = urn.tblCariler.CariAdi;
                txtKayitBul.Text = urn.UrunGenelNo;
                txtUKodu.Text = urn.UrunKodu;
                txtUAciklama.Text = urn.UrunAciklama;
                txtUAdi.Text = urn.UrunAdi;
                txtUAlis.Text = urn.AlisFiyat.ToString();
                txtUSatis.Text = urn.SatisFiyat.ToString();
                txtUKutuIcerik.Text = urn.KutuIcerik;
                txtKullanimAy.Text = urn.KullanimSuresiAy.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Guncelle()
        {
            if (secimId == -1)
            {
                return;
            }
            try
            {
                tblUrunler urn = urunler;
                urn.UrunAdi = txtUAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatis.Text);
                urn.KutuIcerik = txtUKutuIcerik.Text;
                urn.UrunGenelNo = txtKayitBul.Text;
                urn.UrunAciklama = txtUAciklama.Text;
                urn.KullanimSuresiAy = (int) txtKullanimAy.Value;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;

                db.SaveChanges();

                MessageBox.Show("Guncelleme basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?) Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler hst = urunler;
                hst.isActive = false;
                db.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtKayitBul.ClientSize.Height + 0);
            btn.Location = new Point(txtKayitBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayitBul.Controls.Add(btn);
            //SendMessage(txtKayitBul.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUrunlerListesi"] == null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
