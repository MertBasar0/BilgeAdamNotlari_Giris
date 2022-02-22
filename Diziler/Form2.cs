using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] Arabalar = { "mercedes", "ferrari", "bugatti", "audi", "seat", "honda", "alfaRomeo"};
        Random rnd = new Random();
        int[] sayilar = new int[21];

        private void btn_sonEleman_Click(object sender, EventArgs e)
        {
            string soneleman= Arabalar[Arabalar.Length - 1];
            MessageBox.Show("son eleman=>" + soneleman);
        }

        private void btn_rasgeleGetir_Click(object sender, EventArgs e)
        {
            string rasgele = Arabalar[rnd.Next(0,Arabalar.Length)];
            label1.Text = rasgele;
        }


        string[] Dizi = { "mercedes", "ford", "fiat", "bugatti" };
        int index = 0;
        private void btn_sırala_Click(object sender, EventArgs e)
        {

            //butona her basıldığında sırasıyla tek tek listeye eleman ekleme işlemi yapılsın.
            int[] sayi = { 0, 1, 2, 3, 4 };

            listBox1.Items.Add(Dizi[sayi[index]]);
            index++;
        }


        //random 20 sayıdan ortalamanın altında kalanları bulma
        private void btn_diziSıralama_Click(object sender, EventArgs e)
        {
            int avg = 0;
            int toplam = 0;
            
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar += rnd.Next(0,20);
            //    sayilar[i] += toplam;
            //    avg = toplam / 20;
               
            //}
            listBox2.Items.Add(avg);
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < avg)
                {
                    this.Text="ortalamanın altında"+i+"sayı var";
                }
            }
          



        }
        
    }
}
