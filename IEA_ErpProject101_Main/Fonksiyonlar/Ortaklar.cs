using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.Entity;

namespace IEA_ErpProject101_Main.Fonksiyonlar
{
    public class Ortaklar : Form
    {
        public Ortaklar()
        {
            
        }
        protected ErpProjectWMPEntities db = new ErpProjectWMPEntities();
        internal formlar f = new formlar();
        internal Numaralar n = new Numaralar();
    }
}
