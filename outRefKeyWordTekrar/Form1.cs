using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outRefKeyWordTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kuvvetiniAlma(int sayi, out double sonuc)
        {
            sonuc = Math.Pow(sayi, 2);
        }
        //Sizden geriye değer dönmeyen bir hesapla methodu yazmanı istiyorum.. iki sayı alacak ve dışarıya toplam beş adet sonuc dönecek
        //toplam,fark,çarpım,bölüm,mod
        
        void hesaplamalar (int sayi1, int sayi2, out int toplam, out int cıkarma, out int bolme, out int carpma, out int mod)
        {
            toplam = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            bolme = sayi1 / sayi2;
            carpma = sayi1 * sayi2;
            mod = sayi1 % sayi2;

        }
        void asdasasd(ref int[] sonuclar, int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            int cıkarma = sayi1 - sayi2;
            int bolme = sayi1 / sayi2;
            int carpma = sayi1 * sayi2;
            int mod = sayi1 % sayi2;

            sonuclar = new int[5];

            sonuclar[0] = toplam;
            sonuclar[1] = cıkarma;
            sonuclar[2] = bolme;
            sonuclar[3] = carpma;
            sonuclar[4] = mod;

            foreach (var item in sonuclar)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //int toplam= 0;
            //int cıkarma= 0;
            //int bolme = 0;
            //int carpma = 0;
            //int mod = 0;
            //hesaplamalar(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), out toplam, out cıkarma, out bolme, out carpma, out mod);
            //int [] sonuclar = {toplam,cıkarma, bolme,carpma,mod};       
            //foreach (var item in sonuclar)
            //{
            //    listBox1.Items.Add(item);
            //}

            asdasasd(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }
    }
}
