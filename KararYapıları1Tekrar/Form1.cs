using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları1Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Dışarıdan kullanıcı ADMİN GİRERSE HOŞELDİN ADMİN, ADMİN DEĞİLSE TANIYAMADIM DİYECEK.
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //string kadi = (textBox1.Text.ToLower());
            //string sifre = (textBox2.Text);
            //if (kadi=="admin" && sifre=="1234" )
            //{
            //    MessageBox.Show("Hoşgeldin Admin");
            //}
            //else
            //{
            //    MessageBox.Show("tanıyamadım");
            //}
            string kadi = textBox1.Text.ToLower();
            string sifre = textBox2.Text;
            if (kadi=="admin" && sifre=="1234")
            {
                giris sfaasfs = new giris();
                sfaasfs.Show();
                this.Hide();
            }
        }

        //Ödev Kadi: Admin şifresi: 123 geldiğinde form2 açılsın içerisindeki label' a hoşgeldin admin yazsın.
    }
}
