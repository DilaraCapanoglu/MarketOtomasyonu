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
    public class Kozmetik:Urun
    {
        private string kozmetik;
        public string Kozmetik1
        {
            get { return kozmetik; }
            set { kozmetik = value; }
        }
       
        public override double Kdv(int fiyat)
        {
            return base.Kdv(fiyat);
        }
        
    }
}
