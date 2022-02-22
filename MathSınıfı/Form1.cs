using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            string deger = "";
            deger = Math.PI.ToString();

            deger = deger.Substring(0, 4);
            label1.Text = deger;
        }

        private void btn_abs_Click(object sender, EventArgs e)
        {
            int mutlakDeger = Math.Abs(-45);
            label1.Text = mutlakDeger.ToString();
        }

        private void btn_floor_Click(object sender, EventArgs e)
        {
            //verilen ondalıklı değeri bir alt değere yuvarlar.

            double deger = Math.Floor(12.99);
            label1.Text = deger.ToString();
        }

        private void btn_Ceiling_Click(object sender, EventArgs e)
        {
            double deger = Math.Ceiling(12.01);
            label1.Text=deger.ToString(); 
        }

        private void btn_round_Click(object sender, EventArgs e)
        {
            //.'dan önceki sayı çift ise bir alt değere, tek ise bir üst değere tamamlar.

            double deger = Math.Round(12.50);
            label1.Text = deger.ToString();
        }

        private void btn_truncate_Click(object sender, EventArgs e)
        {
            // Sayının ondalıklı kısmına bakmaz, yalnızca tam kısmı sizlere verir.
            double deger = Math.Truncate(75.20);
            label1.Text = deger.ToString();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            int max = Math.Max(45, 65);
            label1.Text = max.ToString();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            int max = Math.Min(45, 65);
            label1.Text = max.ToString();
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            // üs alma
            double kuvvet = Math.Pow(3, 4);
            label1.Text = kuvvet.ToString();
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            //Karakök

            double deger = Math.Sqrt(16);
            label1.Text = deger.ToString();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            //Bir sayının negatif, pozitif yada 0'a eşitlik durumunu kontrol eder.
            //negatif == -1
            //pozitif == 1
            //0 == 0
            int deger = Math.Sign(12);
            label1.Text =deger.ToString();

        }
    }
}
