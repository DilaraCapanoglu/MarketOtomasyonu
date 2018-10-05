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
    public partial class Form1 : Form
    {
        Form5 frm5 = new Form5();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
          {  


        string k_adı;
        string sifre;
            k_adı = textBox1.Text;
            sifre = textBox4.Text;
            if ((k_adı.Length>0) && (sifre.Length>0))//Kullanıcı adı ve şifre girilirse form2 yi göster
            {
                frm5.Show();//form5 yi göster
                this.Hide();//form1 i gizle
            }
            else//eger girilimezse
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Giriniz!");//uyarı ver
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
