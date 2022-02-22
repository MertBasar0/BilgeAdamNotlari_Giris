using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("toplama işlemi yapar.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            //Console bizlerin data okumasını sağlayan metod Readline()
            //Fakat burada bu şekilde bir metod'a gerek yok çünkü nesneleri kullanıyoruz.
     

    
        private void txt_ikinciSayi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {

            string gelenDegerbir = txt_BirinciSayi.Text;
            string gelenDegeriki = txt_İkinciSayi.Text;
            string toplam = gelenDegerbir + gelenDegeriki;
            MessageBox.Show(toplam);

            int cevrilenDegerBir = Convert.ToInt32(txt_BirinciSayi.Text);
            int cevrilenDegerİki = Convert.ToInt32(txt_İkinciSayi.Text);
            int Mat_Toplam = cevrilenDegerBir + cevrilenDegerİki;


            MessageBox.Show(Mat_Toplam.ToString());
            this.Text = Mat_Toplam.ToString();
        }

    }
}
