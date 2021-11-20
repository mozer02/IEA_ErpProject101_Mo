using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller;
using IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri;

namespace IEA_ErpProject101_Main.Fonksiyonlar
{
    class formlar
    {
        public int HastaneListesi(bool secim = false)
        {
            frmHastanelerListesi frm = new frmHastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int DoktorlarListesi(bool secim = false)
        {
            frmDoktorlarListesi frm = new frmDoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int PersonellerListesi(bool secim = false)
        {
            frmPersonellerListesi frm = new frmPersonellerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int FirmalarListesi(bool secim = false)
        {
            frmFirmalarListesi frm = new frmFirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }

        public int StokGirisListesi(bool secim = false)
        {
            frmStokGirisListe frm = new frmStokGirisListe();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }

        public void StokGuncelleAc()
        {
            frmStokGuncelle gnc = new frmStokGuncelle();
            gnc.ShowDialog();
        }
    }
}
