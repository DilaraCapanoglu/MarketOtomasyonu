using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace WindowsFormsApplication1
{
    public class Giyim : Urun
    {
        private string giyim;
        public string Giyim1
        {
            get { return giyim; }
            set { giyim = value; }
        }
        
        public override double Kdv(int fiyat)
        {
            return base.Kdv(fiyat)*1.08;

        }

        
        

    }
}

