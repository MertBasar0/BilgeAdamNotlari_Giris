using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngü_Örnekleri_Tekrar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //ikisayiArasındakiAsalSayilari bulalım. 
            int sayi = Convert.ToInt32(textBox1.Text);
            int tamcarpanlar = 0;

            for (int i = 2; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    tamcarpanlar += i;
                    for (int k = 2; i <= tamcarpanlar; k++)
                    {
                        if (tamcarpanlar%k!=0)
                        {
                            listBox1.Items.Add("-");
                        }
                        else
                        {
                            listBox1.Items.Add(k.ToString());
                        }
                    }
                }
            }
        }
    }
}
