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
  public  class Urun
    {
        private string kategori;
        private string uAdı;
        private string sKullanma;
        private string uTarihi;
        private int uFiyat;
        private int stok;
        public virtual double Kdv(int fiyat)
        {
            this.UFiyat = fiyat;
            return UFiyat*1.08;
        }
      public string Kategori { get { return kategori; }
            set { kategori = value; }
        }
        public string UAdı {
            get { return uAdı; }
            set { uAdı = value; }
        }
        public string SKullnma
        {
            get {return sKullanma;}
            set { sKullanma = value; }
        }  
        public string UTarihi
        {
            get { return uTarihi; }
            set { uTarihi = value; }
        }     
        public int UFiyat
        {
            get { return uFiyat; }
            set { uFiyat = value; }
        }
        public int Stok
        {
            get { return stok; }
            set { stok = value; }
        }



    }
}