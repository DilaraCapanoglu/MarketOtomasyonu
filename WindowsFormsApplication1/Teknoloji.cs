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
  public  class Teknoloji:Urun
    {
        private string teknoloji;
        public string Teknoloji1
        {
            get { return teknoloji; }
            set { teknoloji = value; }

        }
        
        public override double Kdv(int fiyat)
        {
            return base.Kdv(fiyat)*1.2;
        }
       

    }

}
