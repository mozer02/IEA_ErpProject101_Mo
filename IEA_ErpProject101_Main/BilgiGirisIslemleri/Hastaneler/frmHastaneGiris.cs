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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler
{
    public partial class frmHastaneGiris : Ortaklar
    {
        private readonly ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;

        public frmHastaneGiris()
        {
            InitializeComponent();
        }

        private void frmHastaneGiris_Load(object sender, EventArgs e)
        {
            //lblHastaneKodu.Text = n.CariKoduHastane();
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       where s.CariGroupId==1
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1
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
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            lblHastaneKodu.Text = n.CariKoduHastane();
        }

        private void ComboDoldur()
        {
            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var lst1 = db.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var lst2 = db.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var lst3 = db.tblSehirler.ToList();

            //txtDepartman1.Items.Clear();
            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";
            txtDepartman1.SelectedIndex = -1;

            //txtDepartman2.Items.Clear();
            txtDepartman2.DataSource = lst1;
            txtDepartman2.ValueMember = "Id";
            txtDepartman2.DisplayMember = "DepartmanAdi";
            txtDepartman2.SelectedIndex = -1;

            //txtDepartman3.Items.Clear();
            txtDepartman3.DataSource = lst2;
            txtDepartman3.ValueMember = "Id";
            txtDepartman3.DisplayMember = "DepartmanAdi";
            txtDepartman3.SelectedIndex = -1;

            //txtSehir.Items.Clear();
            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;


        }

        private void frmHastaneGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.kontrol = false;
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string hkodu = n.CariKoduHastane();
            try
            {
                if (secimId==-1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtHastaneAdi.Text;
                    hst.CariMail = txtHastMail.Text;
                    hst.CariTel = txtHastTel.Text;
                    hst.YetkiliAdi1 = txtYet1.Text;
                    hst.YetkiliAdi2 = txtYet2.Text;
                    hst.YetkiliAdi3 = txtYet3.Text;
                    hst.YetkiliDepartmani1 = txtDepartman1.Text;
                    hst.YetkiliDepartmani2 = txtDepartman2.Text;
                    hst.YetkiliDepartmani3 = txtDepartman3.Text;
                    hst.YetkiliTel1 = txtYtel1.Text;
                    hst.YetkiliTel2 = txtYtel2.Text;
                    hst.YetkiliTel3 = txtYtel3.Text;
                    hst.YetkiliCep1 = txtYcep1.Text;
                    hst.YetkiliCep2 = txtYcep2.Text;
                    hst.YetkiliCep3 = txtYcep3.Text;
                    hst.YetkiliMail1 = txtEmail1.Text;
                    hst.YetkiliMail2 = txtEmail2.Text;
                    hst.YetkiliMail3 = txtEmail3.Text;
                    hst.Adres1 = txtAdres1.Text;
                    hst.Adres2 = txtAdres2.Text;
                    hst.CariGroupId = 1;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtHastaneCari.Text;
                    hst.Vdairesi = txtVergiDairesi.Text;
                    hst.Tc_Vn = txtVnTc.Text;
                    hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;//db.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariNo = hkodu;

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
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
                hst.CariAdi = txtHastaneAdi.Text;
                hst.CariMail = txtHastMail.Text;
                hst.CariTel = txtHastTel.Text;
                hst.YetkiliAdi1 = txtYet1.Text;
                hst.YetkiliAdi2 = txtYet2.Text;
                hst.YetkiliAdi3 = txtYet3.Text;
                hst.YetkiliDepartmani1 = txtDepartman1.Text;
                hst.YetkiliDepartmani2 = txtDepartman2.Text;
                hst.YetkiliDepartmani3 = txtDepartman3.Text;
                hst.YetkiliTel1 = txtYtel1.Text;
                hst.YetkiliTel2 = txtYtel2.Text;
                hst.YetkiliTel3 = txtYtel3.Text;
                hst.YetkiliCep1 = txtYcep1.Text;
                hst.YetkiliCep2 = txtYcep2.Text;
                hst.YetkiliCep3 = txtYcep3.Text;
                hst.YetkiliMail1 = txtEmail1.Text;
                hst.YetkiliMail2 = txtEmail2.Text;
                hst.YetkiliMail3 = txtEmail3.Text;
                hst.Adres1 = txtAdres1.Text;
                hst.Adres2 = txtAdres2.Text;
                hst.CariTipId = 1;
                hst.CariUnvan = txtHastaneCari.Text;
                hst.Vdairesi = txtVergiDairesi.Text;
                hst.Tc_Vn = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;//db.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId>0)
            {
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

        private void txtSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (txtSehir.SelectedValue!=null)
            //{
            //    txtAdres2.Text = txtSehir.SelectedValue.ToString(); 
            //}
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimId hatasi almamak icin bu islemi yaptim
            Home.tblCarilerId = db.tblCariler.Find(id);
            try
            {
                tblCariler hst = Home.tblCarilerId;
                txtHastaneAdi.Text = hst.CariAdi;
                txtHastMail.Text = hst.CariMail;
                txtHastTel.Text = hst.CariTel;
                txtYet1.Text = hst.YetkiliAdi1;
                txtYet2.Text = hst.YetkiliAdi2;
                txtYet3.Text = hst.YetkiliAdi3;
                txtDepartman1.Text = hst.YetkiliDepartmani1;
                txtDepartman2.Text = hst.YetkiliDepartmani2;
                txtDepartman3.Text = hst.YetkiliDepartmani3;
                txtYtel1.Text = hst.YetkiliTel1;
                txtYtel2.Text = hst.YetkiliTel2;
                txtYtel3.Text = hst.YetkiliTel3;
                txtYcep1.Text = hst.YetkiliCep1;
                txtYcep2.Text = hst.YetkiliCep2;
                txtYcep3.Text = hst.YetkiliCep3;
                txtEmail1.Text = hst.YetkiliMail1;
                txtEmail2.Text = hst.YetkiliMail2;
                txtEmail3.Text = hst.YetkiliMail3;
                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;
                txtHastaneCari.Text = hst.CariUnvan;
                txtVergiDairesi.Text = hst.Vdairesi;
                txtVnTc.Text = hst.Tc_Vn;
                txtSehir.Text = hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariNo;
                txtKayitBul.Text = hst.CariNo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pnlOrta_Scroll(object sender, ScrollEventArgs e)
        {

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
            if (Application.OpenForms["frmHastanelerListesi"]==null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }
    }
}
