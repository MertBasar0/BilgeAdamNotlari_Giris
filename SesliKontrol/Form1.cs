using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void sesliKontrol(TextBox textBox)
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            string kelime = textBox.Text.ToLower();
            int sesliSayisi = 0;


            char harf;
            for (char i = 'a'; i < 'z'; i++)
            {
                harf = i;
                foreach (var item in sesliler)
                {
                    if (harf == item)
                    {
                        for (int k = 0; k < kelime.Length; k++)
                        {
                            if (kelime[k]==item)
                            {
                                listBox1.Items.Add(kelime[k]);
                                sesliSayisi++;
                            }
                        }
                    }
                    else
                    {
                        for (int s = 0; s < kelime.Length; s++)
                        {
                            if (kelime[s] == harf)
                            {
                                listBox2.Items.Add(kelime[s]);
                            }                          
                        }
                    }
                }
            }
            MessageBox.Show($"{sesliSayisi} sesli harf vardır..");

            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    for (int k = 0; k < sesliler.Length; k++)
            //    {
            //        if (kelime[i]==sesliler[k])
            //        {
            //            listBox1.Items.Add(kelime[i]);
            //            sesliSayisi++;
            //        }
            //    }
            //    if(kelime[i] != sesliler[k])
            //    {
            //        listBox2.Items.Add(kelime[i]);
            //    }
            //}
            //MessageBox.Show($"{sesliSayisi} sesli harf vardır..");



        }

        private void btn_sesliKontrol_Click(object sender, EventArgs e)
        {
            //Textbox'dan gelen değerde eğer sesli bir harf varsa, o harfi 1. listbox'a atın ve kaç adet olduğunu messagbox'da gösterin,
            //eğer bu kelimede sesli yoksa sesli harf yoktur desin
            //Girilen metinde sessiz harfleride listbox2' ye atınız. Kullanıcı küçük yada büyük harf gözetmeksizin giriş yapabilir. Fakat siz bunun hepsini
            //küçük olarak kabul edin.

            sesliKontrol(textBox1);
           
           

        }
    }
}
