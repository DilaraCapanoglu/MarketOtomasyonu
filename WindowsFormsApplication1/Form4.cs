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
using System.Xml.Linq;


namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekleme butonu
            Kategori urun = new Kategori();
            urun.Kategori = comboBox1.Text;
            urun.UAdı = txtuAdı.Text;
            urun.UFiyat = Convert.ToInt32(txtFiyat.Text);
            urun.SKullnma = dateTimePicker2.Text;
            urun.UTarihi = dateTimePicker1.Text;
            urun.Stok = Convert.ToInt32(txtStok.Text);

            urun.UrunKaydet();
            Listele();
            MessageBox.Show("Ürün Eklendi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //kaydet butonu
            Kategori urun = new Kategori();
            DataTable dt = (DataTable)dataGridView1.DataSource;

            urun.UrunKaydet(dt);
            Listele();
            MessageBox.Show("Ürünler Kaydedildi");
        }
        //ürünlerin listesini getirir
        private void Listele()
        {
            Kategori urun = new Kategori();
            DataTable dt = urun.UrunListesiGetir();
            dataGridView1.DataSource = dt;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //silme butonu
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
    

            MessageBox.Show("Ürün Silindi");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bttngünclle_Click(object sender, EventArgs e)
        {
        

        }

        private void txtuTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
