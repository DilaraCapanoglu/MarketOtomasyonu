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
    public partial class Form2 : Form
    {
        Form3 frm3 = new Form3();

        
    public Form2()
        {// datagridview de seçili satırları koyu mavi yapıyoruz
            InitializeComponent();
            dataGridView2.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView2_CellFormatting);
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Selected)

            {



                //seçli satırı kalın yapıyoruz.

                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);



                //seçli satırın backcolor rengini koyu mavi yapıyoruz.

                e.CellStyle.SelectionBackColor = Color.DarkBlue;

                //seçili satır yazı rengini beyaz yapıyoruz

                e.CellStyle.SelectionForeColor = Color.White;

            

        }
    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    

        private void Form2_Load_1(object sender, EventArgs e)
        {

            

            Kategori urn = new Kategori();
            DataTable dt = urn.UrunListesiGetir();
            dataGridView2.DataSource=  dt;
        
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           //ürün arama 
            Kategori urn = new Kategori();
            DataTable dt=urn.UrunArama(urunaramatextbox.Text);
            dataGridView2.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("Ürün bulunamadı", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

           
        }


        public static int fiyat;
        private void button2_Click_1(object sender, EventArgs e)
        { 
        Form3 frm3 = new Form3();

            //string secili = dataGridView2.SelectedRows.ToString();
            DataTable dt = new DataTable();
           // dt = gda.GıdaListesi();
            //dataGridView2.DataSource = dt;
            Giyim gym = new Giyim();
            Kozmetik kzmk = new Kozmetik();
            Aksesuar aks = new Aksesuar();
            Gıda gda = new Gıda();
            Teknoloji tkn = new Teknoloji();
            
        string kt = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            switch (kt) {
             
                case "Gıda":
                    fiyat += Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    textBox1.Text = gda.Kdv(fiyat).ToString();
                  
                    return;
                case "Kozmetik":
                    fiyat += Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    textBox1.Text = kzmk.Kdv(fiyat).ToString();
                  
                    return;
                case "Aksesuar":
                    fiyat += Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    textBox1.Text = aks.Kdv(fiyat).ToString(); return;
                case "Giyim":
                    fiyat  += Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    textBox1.Text = gym.Kdv(fiyat).ToString(); return;
                case "Teknoloji":
                    fiyat += Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    textBox1.Text = tkn.Kdv(fiyat).ToString();return; 
                default: MessageBox.Show("Lütfen Bir Kategori Seçiniz!"); return; 
                    
            }

            //foreach (DataGrid row in dataGridView2.Rows)
            //{
                
            //}

        }

        private void button3_Click_1(object sender, EventArgs e)
        {//seçtiğimiz ürünlerin fiyatını ödeme formuna aktarır
            Form3 frm3 = new Form3();
            frm3.textBox1.Text = textBox1.Text;
            frm3.Show();
            this.Hide();
        }
      
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            
        }

        private void urunaramatextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
