using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outRefKeyWordTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kuvvetiniAlma(int sayi, out double sonuc)
        {
            sonuc = Math.Pow(sayi, 2);
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            kuvvetiniAlma(Convert.ToInt32(textBox1),sonuc);
        }
    }
}
