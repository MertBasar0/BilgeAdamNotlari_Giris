using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notHesaplaOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ortalama(int s1, int s2, out int ort)
        {
           
            ort = (s1 + s2) / 2;
        }

        void ortalama (int s1 ,int s2, int szl, out int ort)
        {
            ort = (s1 + s2 +szl)/2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            if (txtSozlu.Text == "")
            {
                ortalama(Convert.ToInt32(txtSinav1.Text) ,Convert.ToInt32(txtSinav2.Text),out sonuc);
                MessageBox.Show("" + sonuc);
            }
            else
            {
                ortalama(Convert.ToInt32(txtSinav1.Text), Convert.ToInt32(txtSinav2.Text),Convert.ToInt32(txtSozlu.Text),out sonuc);
                MessageBox.Show("" + sonuc);
            }
        }
    }
}
