using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLabOrnekleriTEkrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carpımTablosu_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    sonuc = i * j;
                    listBox1.Items.Add($"{i}x{j}={sonuc}");
                }
                listBox1.Items.Add("\n------------");
            }            
        }

        private void btn_caprazX_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    label1.Text += "x";
                }
                label1.Text +="\n";
            }
        }
    }
}
