using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btn_doWhile_Click(object sender, EventArgs e)
            //Şart sağlanmasa dahi kod bloğunu bir kere çalıştırır.
        {
            int i = 100;

            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i<100);
        }

        private void btn_While2_Click(object sender, EventArgs e)
        {
            int carpim = 1;
            int i = 0;
            while (i>0)
            {
                carpim = carpim * i;
                i--;
            }
            MessageBox.Show(carpim.ToString());
        }

        private void btn_doWhile2_Click(object sender, EventArgs e)
        {
            int carpim = 1;
            int i = 0;

            do
            {
                carpim = carpim * i;
                i--;
            } while (i>0);
            MessageBox.Show(carpim.ToString());
        }
    }
}
