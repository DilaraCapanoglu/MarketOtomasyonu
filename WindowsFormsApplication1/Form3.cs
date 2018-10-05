using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }
        public static double fiyt, pesinat, taksit, tutar, sayı;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button3_Click(object sender, EventArgs e)
            {
            
            //peşinat ve taksit rakamlarını girerek aylık  ne kadar ödeyeceğini hesaplayar
            //ve satın alır
            pesinat = Convert.ToDouble(textBox2.Text);
            taksit = Convert.ToDouble(textBox3.Text);
            fiyt = Convert.ToDouble(textBox1.Text);
            sayı = ((fiyt - pesinat)/taksit);
            tutar = Convert.ToDouble(sayı);
            textBox4.Text = "₺ "+tutar.ToString();
            

        }
        

       

        public void Form3_Load(object sender, EventArgs e)
        {
           
            Form2 frm2 = new Form2();
            Kategori urn = new Kategori();
      

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Kategori";
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[2].Name = "Ürün Fiyatı";
            dataGridView1.Columns[3].Name = "Son Kullanma";
            dataGridView1.Columns[4].Name = "Üretim Tarihi";
            dataGridView1.Columns[5].Name = "Stok";

         //   dataGridView1.Rows.Add(frm2.dataGridView2.SelectedRows.ToString());
         
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi Tercih Ettiğiniz Teşekkürler"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label7.Text = dt.ToShortDateString();
            label9.Text = dt.ToShortTimeString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
