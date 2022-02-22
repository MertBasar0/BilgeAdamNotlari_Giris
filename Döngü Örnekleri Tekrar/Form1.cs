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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mukemmelSayi_Click(object sender, EventArgs e)
        {
            //mükemmel sayı= kendisi hariç tam çarpanları toplamı kendisine eşit olan sayıya denir.

            int sayi =Convert.ToInt32(textBox1.Text);
            int carpanlar = 0;

            for (int i = 1; i < sayi  ; i++)
            {
                if (sayi%i==0)
                {
                    carpanlar += i;
                }
            }
            if (carpanlar==sayi)
            {
                MessageBox.Show("Bu sayi mükemmeldir..");
            }
            else
            {
                MessageBox.Show("Bu sayı mükemmel değildir..");
            }
        }
    }
}
