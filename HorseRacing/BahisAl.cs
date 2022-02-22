using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class BahisAl : Form
    {
        public BahisAl()
        {
            InitializeComponent();
        }

        private void btn_yarisaDon_Click(object sender, EventArgs e)
        {
            Form1 yaris = new Form1();
            yaris.Show();  
            this.Hide();
        }

        private void btn_Bahis_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                double tahminikazanc = Convert.ToDouble(numericUpDown1.Value) * 1.70;

               MessageBox.Show("Tahmini kazancınız "+tahminikazanc+" dir Bol Şans..");
            }
            else if (radioButton2.Checked == true)
            {
                double tahminikazanc = Convert.ToDouble(numericUpDown1.Value) * 2.00;
                MessageBox.Show("Tahmini kazacınız "+tahminikazanc+" dir Bol Şans..");
            }
            else if (radioButton3.Checked == true)
            {
                double tahminikazanc = Convert.ToDouble(numericUpDown1.Value) * 2.50;
                MessageBox.Show("Tahmini kazancınız "+tahminikazanc+" dir Bol Şans..");
            }
            
        }
    }
}
