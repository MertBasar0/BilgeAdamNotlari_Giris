using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDöngüsü2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sayma_Click(object sender, EventArgs e)
        {
            ForDonguleri.Items.Clear();
            //1-1000 arası sayıları listeye yazdırma.
            for (int i = 1; i <= 1000; i++)
            {
                ForDonguleri.Items.Add(i);
            }
        }

        private void btn_tersSay_Click(object sender, EventArgs e)
        {
            ForDonguleri.Items.Clear();
            //1-1000 arası ters sayma.
            for (int i = 1000; i >=1 ; i--)
            {
                ForDonguleri.Items.Add(i);
            }
        }

        private void btn_ikiserSayma_Click(object sender, EventArgs e)
        {
            ForDonguleri.Items.Clear();
            //2'den başlatıp 1000'e kadar 2şer arttırarak çift sayıları alma.
            for (int i = 2; i <= 1000; i+=2)
            {
                ForDonguleri.Items.Add(i);
            }
        }

        private void btn_toplamıBas_Click(object sender, EventArgs e)
        {
            ForDonguleri.Items.Clear();
            //1-1000 arasındaki sayıların toplamını ekrana bastırınız..
            int sonuc = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sonuc += i;               
            }
            MessageBox.Show(sonuc.ToString());
        }

        private void btn_A_Z_Click(object sender, EventArgs e)
        {
            ForDonguleri.Items.Clear();
            //Alfabetik olarak a-z ye sıralama yapınız..
            string harf;

            for (char i = 'A'; i < 'Z'; i++)
            {
                ForDonguleri.Items.Add(i);
            }
        }

        private void btn_toplamınınKaresi_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki çift sayıların toplamı ile, tek sayıların toplamının farkları karesi kaçtır.
            ForDonguleri.Items.Clear();
            int tekToplam =0;
            int çiftToplam =0;
            double sonuc =0;

            for (int deger1 = 1; deger1 <= 100; deger1+=2)
            {
                tekToplam += deger1;
            }

            for (int deger2 = 2; deger2 < 100; deger2+=2)
            {
                çiftToplam += deger2;
            }
            sonuc =Math.Pow(tekToplam - çiftToplam, 2);
            MessageBox.Show(sonuc.ToString());

        }

        private void btn_yıllar_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar listbox a eklensin ancak 1990-1992 yılları dahil olmasın.
            ForDonguleri.Items.Clear();
            for (int i = 1945; i < 2022; i++)
            {
                if (i>=1945 && i<1990 || i>1992 && i<=2022)
                {
                    ForDonguleri.Items.Add(i);
                }
            }            
        }
    }
}