using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Mantıksal operatörler
        //Bazen birden fazla durumu aynı anda kontrol etmek istiyor olabilirsiniz. Bu gibi durumlarda operatörlerdne yararlanılır.
        //&& (ve)(kontrol bloğu içerisinde yer alan tüm koşullardan herhangi birinin sağlanması durumunda işaret eder..)
        //öylece bir koşul sağlansa bloğunuzda yazdığınız kodlar harekete geçer
        

        //Yukarıda yazdığımız operatörler "kısa devre operatörü" olarak geçer. Koşulları kontrolle en soldan başlar, herhangi bir uygunsuzluk durumunda diğer koşullara bakılmaz..Aşağıdaki operatörlerde ise, koşullara uysun veya uymasın hepsi kontrol edilir.

        // & => Ve
        // | => Veya


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            //Girilen Not 0-30 aralığında ise "FF" 30-50 aralığında ise "DD" 50-70 aralığında ise "BB" 70-100 aralığında ise "AA" aldınız şeklinde uyarı versin..           

     /**       int deger = int.Parse(textBox1.Text);

            if (deger == 0 && deger <= 30)
            {
                MessageBox.Show("FF aldınız..");
            }
            else if (deger >= 30 && deger <= 50)
            {
                MessageBox.Show("DD aldınız..");
            }
            else if (deger >= 50 && deger <= 70)
            {
                MessageBox.Show("BB aldınız..");
            }
            else if (deger >= 70 && deger <= 100)
            {
                MessageBox.Show("AA aldınız..");
            }
            else
                MessageBox.Show("Girilen değer doğru değildir..");
     **/
        }
        //Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi reyonda olduğuna dair bilgi verecek
        //Domates, Biber, Patlıcan => Sebze reyonu
        //Diş macunu, Parfüm, Şampuan => Kozmetik reyonu
        //cep telefonu, bilgisayar, ses sistemi=> teknoloji reyonu
        //Bu ürünlerden başka bir ürün girilmesi durumunda bu ürün bizde mevcut değil diyoruz.

        private void btn_ReyonSor_Click(object sender, EventArgs e)
        {

        }

        private void btn_KitapSatis_Click(object sender, EventArgs e)
        {
            //Dışarıdan sipariş alınacak olan kitap bilgisi girilsin. Sipariş sayısı 20'den az ise toplam ücreten %5,20-50 aralığında ise %10, 50-100 aralığında ise %15, 100'den fazla ise %25 indirim yapılsın.

            int kitapFiyat = 5;
            int siparisAdet =int.Parse(textBox2.Text);
            double sonuc = 0;

            if (siparisAdet >0 && siparisAdet<=20)
            {
                sonuc = (siparisAdet * kitapFiyat)*0.95;
            }
            else if(siparisAdet >=20 && siparisAdet <=50)
            {
                sonuc = (siparisAdet * kitapFiyat) * 0.90;
            }
            else if(siparisAdet >=50 && siparisAdet <=100)
            {
                sonuc = (siparisAdet * kitapFiyat) * 0.85;
            }
            else if(siparisAdet >100)
            {
                sonuc = (siparisAdet * kitapFiyat) * 0.75;
            }
            MessageBox.Show("Ödemeniz gereken toplam tutar: " + sonuc + "tl");

        }
    }
}
