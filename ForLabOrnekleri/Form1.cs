using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLabOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CarpımTablosu_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10 ; x++)
                {
                    int sonuc = i * x;   
                    listBox1.Items.Add($"{i}x{x}={sonuc}") ;
                }
                lbl_MetinAlani.Text = "\n";
            }
        }

        private void btn_Ornek4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    lbl_MetinAlani.Text += "x"; 
                    lbl_MetinAlani.Text = lbl_MetinAlani.Text + "x";
                }
                lbl_MetinAlani.Text += "\n";
            }
        }

    }
}
