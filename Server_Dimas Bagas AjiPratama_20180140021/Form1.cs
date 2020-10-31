using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20180140021;

namespace Server_Dimas_Bagas_AjiPratama_20180140021
{
    public partial class Form1 : Form
    {
        ServiceHost hostObj = null;
        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                label2.Text = "Server ON";
                label3.Text = "Klik OFF untuk Mematikan Server";
                button1.Enabled = false;
                button2.Enabled = true;


            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                    ServiceHost hostObj = null;
                    hostObj = new ServiceHost(typeof(Matematika));
                    hostObj.Close();
                    label2.Text = "Server OFF";
                    label3.Text = "Klik ON untuk Menjalankan Server";


                }

                catch (Exception ex)
                {
                    hostObj = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}








    
