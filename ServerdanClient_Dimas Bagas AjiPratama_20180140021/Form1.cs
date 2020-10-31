using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerdanClient_Dimas_Bagas_AjiPratama_20180140021
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new
        ServiceReference1.MatematikaClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1 = Int32.Parse(textBox1.Text);
            int angka2 = Int32.Parse(textBox2.Text);

            label3.Text = "Hasil Penjumlahan"+"="+ obj.Tambah(angka1, angka2 ).ToString();
            label4.Text = "Hasil Pengurangan"+"="+ obj.Kurang(angka1, angka2).ToString();
            label5.Text = "Hasil Perkalian"+"="+ obj.Kali(angka1, angka2).ToString();
            label6.Text = "Hasil Pembagian"+"=" +obj.Bagi(angka1, angka2).ToString();
        }
    }
}
