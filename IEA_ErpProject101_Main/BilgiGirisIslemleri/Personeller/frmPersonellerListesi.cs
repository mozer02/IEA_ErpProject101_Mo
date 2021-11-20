using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonellerListesi : Ortaklar
    {
        //private readonly ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();

        public int secimId = -1;

        public bool Secim = false;
        public frmPersonellerListesi()
        {
            InitializeComponent();
        }

        private void frmPersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
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
            //lblPersonelKodu.Text = n.CariKoduPersonel();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;

            if (secimId > 0&& Secim && Application.OpenForms["frmPersonelGiris"] == null)
            {

                //frmPersonelGiris frm = new frmPersonelGiris();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmPersonelGiris"] != null)
            {
                frmPersonelGiris frm1 = Application.OpenForms["frmPersonelGiris"] as frmPersonelGiris;
                frm1.Ac(secimId);
                Close();
            }
        }
    }
}
