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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dışarıdan aldığınız cümlenin içerisinde kaç sesli harf olduğunu tespit edip gösteriniz..


            //string cumle = textBox1.Text;
            //char [] harf = new char[cumle.Length];
            //int sayac = 0;
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //     harf[i] += cumle[i];

            //    if (harf [i] == 'a'  || harf[i] == 'ı' || harf[i] == 'o' || harf[i] == 'u' || harf[i] == 'e' || harf[i] == 'i' || harf[i] == 'ö' || harf[i] == 'ü')
            //    {
            //        sayac++;
            //    }
            //}
            //MessageBox.Show(sayac.ToString());


            string[] sesli = new string[8];
            int sayac = 0;

            sesli[0] = "a";
            sesli[1] = "e";
            sesli[2] = "ı";
            sesli[3] = "i";
            sesli[4] = "o";
            sesli[5] = "ö";
            sesli[6] = "u";
            sesli[7] = "ü";

            string cumle = textBox1.Text;
            for (int i = 0; i < cumle.Length; i++)
            {

                for (int z = 0; z < 8; z++)
                {
                    if (sesli[z] == cumle[i].ToString())
                    {
                        sayac++;
                    }
                }
            }
            MessageBox.Show("Girdiğiniz cümledekii sesli harf sayısı" + sayac);
        }
    }
}
