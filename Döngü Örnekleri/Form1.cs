using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngü_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mükemmel sayı= kendisi hariç tam çarpanları toplamı kendisine eşit olan sayıya denir.

        }

        private void btn_islem_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            int sayi = int.Parse(textBox1.Text);
            int carpanlar = 0;  
            for (int i = 1; i < sayi; i++)
            {     
                if (sayi % i == 0)
                {
                    carpanlar += i;
                    
                }
            }
            if (carpanlar==sayi)
            {
                label1.Text = "sayı mükemmeldir..";
            }
            else
            {

                label1.Text = "Sayı mükemmle değildir..";
            }
        }


    }
}
