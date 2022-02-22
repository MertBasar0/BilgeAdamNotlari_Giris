using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları2Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //Girilen Not 0-30 aralığında ise "FF" 30-50 aralığında ise "DD" 50-70 aralığında ise "BB" 70-100 aralığında ise "AA" aldınız şeklinde uyarı versin..
            int vize = ((Convert.ToInt32(textBox1.Text)/100)*40);
            int final= ((Convert.ToInt32(textBox2.Text)/100)*60);
            double sonuc = vize+final;
            try
            {
                if (sonuc >= 0 && sonuc <= 30)
                {
                    MessageBox.Show("ff");
                }
                else if (sonuc >= 31 && sonuc <= 50)
                {
                    MessageBox.Show("dd");
                }
                else if (sonuc >= 51 && sonuc <= 70)
                {
                    MessageBox.Show("bb");
                }
                else if (sonuc >= 71 && sonuc <= 100)
                {
                    MessageBox.Show("aa");
                }
                else
                {
                    MessageBox.Show("0-100 arası giriş yapmanız gerekli..");
                }
            }
            catch (Exception mesaj)
            {

                MessageBox.Show(mesaj.Message);
            }
            //Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi reyonda olduğuna dair bilgi verecek
            //Domates, Biber, Patlıcan => Sebze reyonu
            //Diş macunu, Parfüm, Şampuan => Kozmetik reyonu
            //cep telefonu, bilgisayar, ses sistemi=> teknoloji reyonu
            //Bu ürünlerden başka bir ürün girilmesi durumunda bu ürün bizde mevcut değil diyoruz.


            //Dışarıdan sipariş alınacak olan kitap bilgisi girilsin. Sipariş sayısı 20'den az ise toplam ücreten %5,20-50 aralığında ise %10,
            //50-100 aralığında ise %15, 100'den fazla ise %25 indirim yapılsın.


        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            int kitapFiyat = 5;
            int siparisAdet;
            int sonuc;

            if (siparisAdet >= 0 && siparisAdet<=20)
            {
                sonuc = ((siparisAdet * kitapFiyat)/100)*95;
                MessageBox.Show("toplam tutar: "+sonuc);
            }
            else if (siparisAdet>=21 && siparisAdet<=50)
            {
                sonuc=((siparisAdet * kitapFiyat)/100)*95;
                MessageBox.Show("toplam tutar: " + sonuc);
            }
            else if (true)
            {

            }

        }
    }
}
