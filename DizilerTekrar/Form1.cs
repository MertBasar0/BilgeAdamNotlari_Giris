using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] sayilar = new int[20];

        string[] sehirler = { "istanbul", "ankara", "manisa", "sivas       ", "bursa", "edirne", "ordu", "adana" };
        string[] Dizi = { "mercedes", "ford", "fiat", "bugatti" };
        int index = 0;
        private void btn_sırala_Click(object sender, EventArgs e)
        {

            //butona her basıldığında sırasıyla tek tek listeye eleman ekleme işlemi yapılsın.
            int[] sayi = { 0, 1, 2, 3, 4 };

            listBox1.Items.Add(Dizi[sayi[index]]);
            index++;
        }

        private void btn_ortalamaAltı_Click(object sender, EventArgs e)
        {

            //random 20 sayıdan ortalamanın altında kalanları bulma
            listBox1.Items.Clear();
            int tekli = 0;
            int enBuyuk = 0;
            int avg = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                tekli = rnd.Next(0, 150);
                sayilar[i] = tekli;
                if (tekli >= sayilar[i])
                {
                    enBuyuk = tekli;                  
                }              
            }
            avg = enBuyuk / 2;
            for (int k = 0; k < sayilar.Length; k++)
            {
                if (sayilar[k] <= avg)
                {
                    listBox1.Items.Add(sayilar[k]);
                }

            }
        }

        private void btn_sehirGetir_Click(object sender, EventArgs e)
        {
            foreach (var sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
                
            }         
        }

        private void btn_sehirTasi_Click(object sender, EventArgs e)
        {
            foreach (var sehir in listBox1.SelectedItems)
            {
                listBox2.Items.Add(sehir);
            }
        }

        private void btn_sehirBul_Click(object sender, EventArgs e)
        {
            string sehir = textBox1.Text;

            if (sehirler.Contains(sehir))
            {
                listBox1.Items.Add("var");
            }
            else
            {
                listBox1.Items.Add("Böyle bir şehir bulunamadı..");
            }
        }

        private void btn_duzenDegistir_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Black;
                    ctrl.ForeColor = Color.White;
                }
            }
        }
    }
}
