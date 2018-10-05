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
    public class Gıda:Urun
    {
        private string gıda;
        public string Gıda1
        {
            get { return gıda; }
            set { gıda = value; }
        }
       
        public override double Kdv(int fiyat)
        {
            return base.Kdv(fiyat)*1.08;
        }
       
        }

    }
