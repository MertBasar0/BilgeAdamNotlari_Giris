using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenNot = int.Parse(textBox1.Text);


            if (girilenNot<0)
            {
                MessageBox.Show("0'dan küçük değer giremezsiniz..");
            }
            else if(girilenNot>100)
            {
                MessageBox.Show("100'den büyük değer giremezsiniz..");
            }
        }

        private void Kontrol_Click(object sender, EventArgs e)
        {
            int Deger = int.Parse(textBox2.Text);
            

            if (Math.Pow(Deger, 2)==0)
            {
                MessageBox.Show("Değer çifttir..");
            }
            else
            {
                MessageBox.Show("Değer tektir...");
            }

            //Dışarıdan girilen kelime uzunlıuğu 8 karaktere eşit yada büyükse kayıt onaylandı, değilse daha uzun şifre giriniz..
            
        }

        private void btn_Sifre_Click(object sender, EventArgs e)
        {            
            if(textBox3.Text.Length>=8)
            {
                MessageBox.Show("Şifre başarılı..");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre giriniz..");
            }
        }
    }
}
