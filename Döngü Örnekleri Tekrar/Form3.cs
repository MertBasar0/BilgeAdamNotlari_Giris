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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Control_Click(object sender, EventArgs e)
        {
            //dışarıdan aldığınız cümlenin içerisinde kaç sesli harf olduğunu tespit edip gösteriniz..

            string[] dizi = { "a", "ı", "o", "u", "e", "i", "ö", "ü"};

            string kelime = textBox1.Text;
            int sayac = 0;

            for (int i = 0; i < kelime.Length; i++)
            {
                for (int k = 0; k < dizi.Length; k++)
                {
                    if (kelime[i].ToString()==dizi[k])
                    {
                        sayac++;
                    }
                }
            }
            MessageBox.Show(sayac.ToString());
        }

        private void btn_Kontrol2_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;

            for (int i = 0; i < cumle.Length; i++)
            {
                MessageBox.Show(cumle[i].GetType().ToString());            
            }
        }
    }
}
