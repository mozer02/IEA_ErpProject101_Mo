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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    public partial class frmFirmaGiris : Ortaklar
    {
        //private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       where s.CariGroupId == 3
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1,
                           hyetcep=s.YetkiliCep1
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hcode;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                Liste.Rows[i].Cells[7].Value = k.hyetcep;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            lblFirmaKodu.Text = n.CariKoduFirma();
        }

        private void ComboDoldur()
        {
            txtFTipi.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst1 = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst2 = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst3 = db.tblSehirler.ToList();

            //txtDepartman1.Items.Clear();
            txtFDept1.DataSource = lst;
            txtFDept1.ValueMember = "Id";
            txtFDept1.DisplayMember = "DepartmanAdi";
            txtFDept1.SelectedIndex = -1;

            //txtDepartman2.Items.Clear();
            txtFDept2.DataSource = lst1;
            txtFDept2.ValueMember = "Id";
            txtFDept2.DisplayMember = "DepartmanAdi";
            txtFDept2.SelectedIndex = -1;

            //txtDepartman3.Items.Clear();
            txtFDept3.DataSource = lst2;
            txtFDept3.ValueMember = "Id";
            txtFDept3.DisplayMember = "DepartmanAdi";
            txtFDept3.SelectedIndex = -1;

            //txtSehir.Items.Clear();
            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }
        private void YeniKayit()
        {
            string fkodu = n.CariKoduFirma();
            try
            {
                if (txtFAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1 )
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtFAdi.Text;
                    hst.CariMail = txtFMail.Text;
                    hst.CariTel = txtFTel.Text;
                    hst.YetkiliAdi1 = txtFYet1.Text;
                    hst.YetkiliAdi2 = txtFYet2.Text;
                    hst.YetkiliAdi3 = txtFYet3.Text;
                    hst.YetkiliDepartmani1 = txtFDept1.Text;
                    hst.YetkiliDepartmani2 = txtFDept2.Text;
                    hst.YetkiliDepartmani3 = txtFDept3.Text;
                    hst.YetkiliTel1 = txtFYtel1.Text;
                    hst.YetkiliTel2 = txtFYtel2.Text;
                    hst.YetkiliTel3 = txtFYtel3.Text;
                    hst.YetkiliCep1 = txtFYcep1.Text;
                    hst.YetkiliCep2 = txtFYcep2.Text;
                    hst.YetkiliCep3 = txtFYcep3.Text;
                    hst.YetkiliMail1 = txtFYEmail1.Text;
                    hst.YetkiliMail2 = txtFYEmail2.Text;
                    hst.YetkiliMail3 = txtFYEmail3.Text;
                    hst.Adres1 = txtFAdres1.Text;
                    hst.Adres2 = txtFAdres2.Text;
                    hst.CariGroupId = 3;
                    hst.CariTipId = (int)txtFTipi.SelectedValue;
                    
                    hst.Vdairesi = txtVergiDairesi.Text;
                    hst.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }

                    hst.CariUnvan = txtFTipi.Text;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariNo = fkodu;

                    db.tblCariler.Add(hst);
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
                tblCariler hst = Home.tblCarilerId;
                hst.CariAdi = txtFAdi.Text;
                hst.CariMail = txtFMail.Text;
                hst.CariTel = txtFTel.Text;
                hst.YetkiliAdi1 = txtFYet1.Text;
                hst.YetkiliAdi2 = txtFYet2.Text;
                hst.YetkiliAdi3 = txtFYet3.Text;
                hst.YetkiliDepartmani1 = txtFDept1.Text;
                hst.YetkiliDepartmani2 = txtFDept2.Text;
                hst.YetkiliDepartmani3 = txtFDept3.Text;
                hst.YetkiliTel1 = txtFYtel1.Text;
                hst.YetkiliTel2 = txtFYtel2.Text;
                hst.YetkiliTel3 = txtFYtel3.Text;
                hst.YetkiliCep1 = txtFYcep1.Text;
                hst.YetkiliCep2 = txtFYcep2.Text;
                hst.YetkiliCep3 = txtFYcep3.Text;
                hst.YetkiliMail1 = txtFYEmail1.Text;
                hst.YetkiliMail2 = txtFYEmail2.Text;
                hst.YetkiliMail3 = txtFYEmail3.Text;
                hst.Adres1 = txtFAdres1.Text;
                hst.Adres2 = txtFAdres2.Text;
                hst.CariGroupId = 3;
                if (txtFTipi.Text!="")
                {
                    hst.CariTipId = (int)txtFTipi.SelectedValue;
                }

                hst.CariUnvan = txtFTipi.Text;
                hst.Vdairesi = txtVergiDairesi.Text;
                hst.Tc_Vn = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                hst.UpdateUserId = 1;
                hst.UpdateDate = DateTime.Now;


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
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimId hatasi almamak icin bu islemi yaptim
            Home.tblCarilerId = db.tblCariler.Find(id);
            try
            {
                tblCariler hst = Home.tblCarilerId;
                txtFAdi.Text = hst.CariAdi;
                txtFMail.Text = hst.CariMail;
                txtFTel.Text = hst.CariTel;
                txtFYet1.Text = hst.YetkiliAdi1;
                txtFYet2.Text = hst.YetkiliAdi2;
                txtFYet3.Text = hst.YetkiliAdi3;
                txtFDept1.Text = hst.YetkiliDepartmani1;
                txtFDept2.Text = hst.YetkiliDepartmani2;
                txtFDept3.Text = hst.YetkiliDepartmani3;
                txtFYtel1.Text = hst.YetkiliTel1;
                txtFYtel2.Text = hst.YetkiliTel2;
                txtFYtel3.Text = hst.YetkiliTel3;
                txtFYcep1.Text = hst.YetkiliCep1;
                txtFYcep2.Text = hst.YetkiliCep2;
                txtFYcep3.Text = hst.YetkiliCep3;
                txtFYEmail1.Text = hst.YetkiliMail1;
                txtFYEmail2.Text = hst.YetkiliMail2;
                txtFYEmail3.Text = hst.YetkiliMail3;
                txtFAdres1.Text = hst.Adres1;
                txtFAdres2.Text = hst.Adres2;
                txtVergiDairesi.Text = hst.Vdairesi;
                txtVnTc.Text = hst.Tc_Vn;
                if (hst.tblSehirler!=null)
                {
                    txtSehir.Text = hst.tblSehirler.sehir;
                }
                else
                {
                    txtSehir.Text = "";
                }
                lblFirmaKodu.Text = hst.CariNo;
                txtKayitBul.Text = hst.CariNo;
                txtFTipi.Text = hst.CariUnvan;
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
            if (Application.OpenForms["frmFirmalarListesi"] == null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = Home.tblCarilerId;
                hst.isActive = false;
                db.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
