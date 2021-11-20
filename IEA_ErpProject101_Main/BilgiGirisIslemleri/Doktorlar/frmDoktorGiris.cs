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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGiris : Ortaklar
    {
        //private readonly ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();
        
        public int secimId = -1;

        //tblCariler idyeGoreBul;

        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
            
        }

        private void ComboDoldur()
        {
            txtDUnvan.DataSource = Enum.GetValues(typeof(DoktorUnvan));

            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();

            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";
            txtDepartman1.SelectedIndex = -1;

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
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       where s.CariGroupId == 2
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyetcep = s.YetkiliCep1
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
                Liste.Rows[i].Cells[6].Value = k.hyetcep;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            lblHastaneKodu.Text = n.CariKoduDoktor();
        }

        private void YeniKayit()
        {
            string hkodu = n.CariKoduDoktor();
            try
            {
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtDAdi.Text;
                    hst.CariMail = txtDMail.Text;
                    hst.CariTel = txtDTel.Text;
                    hst.YetkiliDepartmani1 = txtDepartman1.Text;
                    hst.YetkiliCep1 = txtDCep1.Text;
                    hst.Adres1 = txtDokHastAdres1.Text;
                    hst.Adres2 = txtDokMuaAdres2.Text;
                    hst.CariGroupId = 2;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtDUnvan.Text;
                    hst.Vdairesi = txtVergiDairesi.Text;
                    hst.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
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

        private void Guncelle()
        {
            if (secimId<0)
            {
                return;
            }
            try
            {
                tblCariler hst = Home.tblCarilerId;
                hst.CariAdi = txtDAdi.Text;
                hst.CariMail = txtDMail.Text;
                hst.CariTel = txtDTel.Text;
                hst.YetkiliDepartmani1 = txtDepartman1.Text;
                hst.YetkiliCep1 = txtDCep1.Text;
                hst.Adres1 = txtDokHastAdres1.Text;
                hst.Adres2 = txtDokMuaAdres2.Text;
                hst.CariTipId = 1;
                hst.CariUnvan = txtDUnvan.Text;
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
        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimId hatasi almamak icin bu islemi yaptim
            Home.tblCarilerId = db.tblCariler.Find(id);
            try
            {
                tblCariler hst = Home.tblCarilerId;
                txtDAdi.Text = hst.CariAdi;
                txtDMail.Text = hst.CariMail;
                txtDTel.Text = hst.CariTel;
                txtDepartman1.Text = hst.YetkiliDepartmani1;
                txtDCep1.Text = hst.YetkiliCep1;
                txtDokHastAdres1.Text = hst.Adres1;
                txtDokMuaAdres2.Text = hst.Adres2;
                txtDUnvan.Text = hst.CariUnvan;
                txtVergiDairesi.Text = hst.Vdairesi;
                txtVnTc.Text = hst.Tc_Vn;
                txtSehir.Text = hst.tblSehirler==null ? "" : hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariNo;
                txtKayitBul.Text = hst.CariNo;
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
            if (Application.OpenForms["frmDoktorlarListesi"] == null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
    }
}
