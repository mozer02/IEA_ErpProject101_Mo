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
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonelGiris : Ortaklar
    {
        //private readonly ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));
            txtPUnvan.SelectedIndex = -1;

            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 6).ToList();

            txtPDepartman.DataSource = lst;
            txtPDepartman.ValueMember = "Id";
            txtPDepartman.DisplayMember = "DepartmanAdi";
            txtPDepartman.SelectedIndex = -1;

            var lst3 = db.tblSehirler.ToList();
            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGroupId == 6
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariNo;
                Liste.Rows[i].Cells[3].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.tblCariler.CariTel;
                Liste.Rows[i].Cells[5].Value = k.tblCariler.CariMail;
                Liste.Rows[i].Cells[6].Value = k.tblCariler.YetkiliCep1;
                Liste.Rows[i].Cells[7].Value = k.IsBasiTarih;
                Liste.Rows[i].Cells[8].Value = k.IsSonuTarih;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            lblPersonelKodu.Text = n.CariKoduPersonel();
        }

        private void YeniKayit()
        {
            string pkodu = n.CariKoduPersonel();
            try
            {
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPAdi.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.CariTel = txtPTel.Text;
                    hst.YetkiliDepartmani1 = txtPDepartman.Text;
                    hst.YetkiliCep1 = txtPCep1.Text;
                    hst.Adres1 = txtPAdres1.Text;
                    hst.Adres2 = txtPAdres2.Text;
                    hst.CariGroupId = 6;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtPUnvan.Text;
                    
                    hst.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariNo = pkodu;

                    db.tblCariler.Add(hst);
                    db.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();

                    pdet.CariId = db.tblCariler.First(x => x.CariAdi == txtPAdi.Text).Id;
                    pdet.IsBasiTarih = txtBaslangic.Value;
                    //pdet.IsSonuTarih = txtBitis.Value;

                    db.tblPersonelDetay.Add(pdet);
                    db.SaveChanges();

                    MessageBox.Show("Kayit basarili");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayit daha once yapilmis. Kendine baska kayit bul...");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblPersonelDetay hst = Home.tblPersonelDetayId;
                hst.tblCariler.CariAdi = txtPAdi.Text;
                hst.tblCariler.CariMail = txtPMail.Text;
                hst.tblCariler.CariTel = txtPTel.Text;
                hst.tblCariler.YetkiliDepartmani1 = txtPDepartman.Text;
                hst.tblCariler.YetkiliCep1 = txtPCep1.Text;
                hst.tblCariler.Adres1 = txtPAdres1.Text;
                hst.tblCariler.Adres2 = txtPAdres2.Text;
                hst.tblCariler.CariTipId = 1;
                hst.tblCariler.CariUnvan = txtPUnvan.Text;
                   
                hst.tblCariler.Tc_Vn = txtVnTc.Text;
                hst.tblCariler.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                hst.tblCariler.UpdateUserId = 1;
                hst.tblCariler.UpdateDate = DateTime.Now;
                hst.IsBasiTarih = txtBaslangic.Value;
                if (txtDurum.Checked)
                {
                    hst.IsSonuTarih = txtBitis.Value;
                }
                

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
            txtDurum.Visible = false;
            label6.Visible = false;
            txtBitis.Visible = false;
            txtBitis.Text = "";
        }
        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimId hatasi almamak icin bu islemi yaptim
            Home.tblPersonelDetayId = db.tblPersonelDetay.Find(id);
            try
            {
                txtDurum.Visible = true;
                tblPersonelDetay hst = Home.tblPersonelDetayId;
                txtPAdi.Text = hst.tblCariler.CariAdi;
                txtPMail.Text = hst.tblCariler.CariMail;
                txtPTel.Text = hst.tblCariler.CariTel;
                txtPDepartman.Text = hst.tblCariler.YetkiliDepartmani1;
                txtPCep1.Text = hst.tblCariler.YetkiliCep1;
                txtPAdres1.Text = hst.tblCariler.Adres1;
                txtPAdres2.Text = hst.tblCariler.Adres2;
                txtPUnvan.Text = hst.tblCariler.CariUnvan;
                
                txtVnTc.Text = hst.tblCariler.Tc_Vn;
                txtSehir.Text = hst.tblCariler.tblSehirler == null ? "" : hst.tblCariler.tblSehirler.sehir;
                lblPersonelKodu.Text = hst.tblCariler.CariNo;
                txtKayitBul.Text = hst.tblCariler.CariNo;
                txtBaslangic.Text = hst.IsBasiTarih.ToString();
                txtBitis.Text = hst.IsSonuTarih.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
            if (Application.OpenForms["frmPersonellerListesi"] == null)
            {
                frmPersonellerListesi frm = new frmPersonellerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
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
                Home.tblCarilerId= db.tblCariler.Find(secimId);
                tblCariler hst = Home.tblCarilerId;
                hst.isActive = false;
                db.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                label6.Visible = true;
                txtBitis.Visible = true;
            }
            else
            {
                label6.Visible = false;
                txtBitis.Visible = false;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?) Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
    }
}
