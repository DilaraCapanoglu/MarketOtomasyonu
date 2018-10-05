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
    class Kategori:Urun
    {



        private string kategori;
           

        public string Kategori1 { get { return kategori; }
            set { kategori = value; }
        }
            



            public static string dosyaUrunler = "Kategori.xml";
            private DataSet dsUrunler = new DataSet("UrunListesi");
            private DataTable dtUrun = new DataTable("Urunler");


            public Kategori()
            {
                DataSetOlustur();
            }

            private void DataSetOlustur()
            {//textboxa girilen verileri xmle ekler 
                if (System.IO.File.Exists(dosyaUrunler))
                {
                    dsUrunler.ReadXml(dosyaUrunler);
                    dtUrun = dsUrunler.Tables[0];
                }
                else
                {
                dtUrun.Columns.Add("Kategori");
                    dtUrun.Columns.Add("Ürün Adı");
                    dtUrun.Columns.Add("Ürün Fiyatı");
                    dtUrun.Columns.Add("Son Kullanma");
                    dtUrun.Columns.Add("Üretim Tarihi");
                    dtUrun.Columns.Add("Stok");
                    dsUrunler.Tables.Add(dtUrun);
                    dsUrunler.WriteXml(dosyaUrunler, XmlWriteMode.WriteSchema);



                }
            }

            public DataTable UrunListesiGetir()
            {
                return dtUrun;
            }

            public void UrunSil()
            {//datagridview de seçili satırı siler

                dtUrun.Rows.Clear();

                dsUrunler.WriteXml(dosyaUrunler, XmlWriteMode.WriteSchema);
            }
       
            public void UrunKaydet()
            {


                DataRow row = dtUrun.NewRow();
            row["Kategori"] = Kategori;
                row["Ürün Adı"] = UAdı;
                row["ürün Fiyatı"] = UFiyat;
                row["Son Kullanma"] = SKullnma;
                row["Üretim Tarihi"] = UTarihi;
                row["Stok"] = Stok;
                dtUrun.Rows.Add(row);
                dsUrunler.WriteXml(dosyaUrunler, XmlWriteMode.WriteSchema);
            }


            public void UrunKaydet(DataTable dt)
            {
                //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
                dsUrunler.Tables.Clear();
                //Yeni Datatable kopyalanır:
                dtUrun = dt.Copy();
                //Datatable tekrar datasete eklenir:
                dsUrunler.Tables.Add(dtUrun);

                dsUrunler.WriteXml(dosyaUrunler, XmlWriteMode.WriteSchema);
            }
     
            public DataTable UrunArama(string uAdı)
            {
                //Önce herhangi bir filtreleme yapmadan(where yazmadan) tüm kayıtları getirir.
                var sonuc = from urun in dtUrun.AsEnumerable()
                            select urun;




                if (uAdı != "") //ürün adı girilmisseürün adına göre arama yap
                {
                    sonuc = from urun in sonuc
                            where urun.Field<string>("Ürün Adı").ToUpper().Contains(uAdı.ToUpper())
                            select urun;
                }




                if (sonuc.Count() > 0) //Filtreleme sonucunda kayıt varsa Datatable olarak döndürsün
                {
                    DataTable dtSonuc = sonuc.CopyToDataTable();
                    return dtSonuc;
                }
                else //arama kriterine uygun kayıt yoksa null döndürsün
                    return null;

            }



        }
    }

