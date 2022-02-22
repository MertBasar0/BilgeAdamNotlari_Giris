using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraySınıfıTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler = { "istanbul", "bursa", "manisa", "sivas", "canakkale", "burdur", "adana", "ankara", "muğla" };
        private void btn_arrayClear_Click(object sender, EventArgs e)
        {
            //Array.Clear();
            bool varMi;
            int index;
            string sehir = textBox1.Text;
            varMi=sehirler.Contains(sehir);
            if (varMi==true)
            {
                index = Array.IndexOf(sehirler, sehir);
                Array.Clear(sehirler, index, 1);
                Array.Resize(ref sehirler, sehirler.Length-1);
                label1.Text = varMi.ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir şehir bulunamadı..");
            }
        }

        private void btn_diziGetir_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.AddRange(sehirler);
        }
    }
}
