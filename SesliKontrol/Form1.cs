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
            bool sesliMi;

            kelime = kelime.ToLower();
            for (int i = 0; i < kelime.Length; i++)
            {
                sesliMi = sesliler.Contains(kelime[i]);
                if (sesliMi == true)
                {
                    listBox1.Items.Add(kelime[i]);
                    sesliSayisi++;
                }
                else
                {
                    listBox2.Items.Add(kelime[i]);
                }
            }
        }

        void sesliKontrolSwitchCase(TextBox textbox)
        {
            char [] karakterler = textbox.Text.ToLower().ToCharArray();
            int sesliSayisi = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                switch (textbox.Text[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        listBox1.Items.Add(textbox.Text[i]);
                        sesliSayisi++;
                        break;

                    default:
                        listBox2.Items.Add(textbox.Text[i]);
                    break;
                }
                 
            }
            
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
