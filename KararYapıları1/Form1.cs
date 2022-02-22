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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ödev Kadi: Admin şifresi: 123 geldiğinde form2 açılsın içerisindeki label' a hoşgeldin admin yazsın.

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            //Dışarıdan kullanıcı ADMİN GİRERSE HOŞELDİN ADMİN, ADMİN DEĞİLSE TANIYAMADIM DİYECEK.

            if (txt_kadi.Text.ToLower()=="admin" && txt_sifre.Text.ToLower()=="123")
            {
              
                Form2 form2 = new Form2();
                form2.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tanıyamadım..");
                Application.Exit();
            }

        }






        //Karar Yapıları
        //Uygulamanızın çalışması esnasında garklı senaryolara göre yanlendirmeler yapabilirsiniz.
        //Örneğin, kullanıcıdan gelen değeri aralıklarına göre uygulamadaki mantıksal işlemlerine göre sonuçlarına göre yönlendirebilirsiniz.
        //3 temel karar yapısı karşımıza çıkar => if else - switch case- Ternary operatörü
        //Karşılaştırma

        //1) ==  (Karşılıklı iki değerin birbiriyle eşit olması durumu)
        //2) !=  (Karşıluklı değerin birbirleriyle eşit olmaması durumu)
        //3) <  (soldaki değerin sağdaki değerinden küçük olması durumu)
        //4) >  (sağdaki değerin soldaki değerden küçük olması durum)
    }
}
