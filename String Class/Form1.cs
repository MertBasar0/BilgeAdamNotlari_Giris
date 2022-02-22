using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OrnekDeger = textBox1.Text;
            int sonuc OrnekDeger.CompareTo("bilgeadam");
            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = ""
                default:
                   break;
           }
        }

        private void btn_Contains_Click(object sender, EventArgs e)
        {
            string test = textBox2.Text;
                bool varMi = test.Contains("adam");

            MessageBox.Show("Aradığınız değer" +" "+ (varMi ? "Bulunmaktadır" : "bulunmamaktadır"));
        }

        private void btn_StartsSwith_Click(object sender, EventArgs e)
        {
            //Kelimennizin parametrede gönderdiğiniz değerle başlayıp başlamadığını size "bool olarak döndürür."

            string test1 = textBox3.Text;
            bool sonuc = test1.StartsWith("bil");

            MessageBox.Show(sonuc ? "kelime \"bil\" ile başlamaktadır" : "kelime \"bil\" ile başlamamaktadır");
        }

        private void btn_EndWith_Click(object sender, EventArgs e)
        {
            string test1 = textBox4.Text;
            bool sonuc = test1.EndsWith("dam");

            MessageBox.Show(sonuc ? "kelime sonu \"dam\" ile başlamaktadır" : "kelime sonu \"dam\" ile başlamamaktadır");
        }

        private void btn_IndexOf_Click(object sender, EventArgs e)
        {
            // IndexOf dizilerde gördüğünüz metodun aynı prensibleriyle çalışmaktadır.
            //Eğer harf varsa harfin indexi yoksa -1 değerini, Harf birden fazla ise ilk harfin indexini döndürür.

            string test2 = textBox5.Text;

            int index = test2.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            //Not: Bir string üzerinde yaptığınız değişiklikler o string'i değiştirmez size yeni bir kopyasını verir.
            //Remove => (1.Kullanım) => Verdiğiniz index numarası dahil, o index' deki tüm karakterleri ortadan kaldıracaktır.
            //Remove => (2. Kullanım) => Verdiğiniz index numarası dahil 2. parametresinde göndermiş olduğunuz değer kadar eleman siler.
            string metin = textBox6.Text;
            // metin = metin.Remove(5); => birinci kullanım. 
            metin = metin.Remove(3, 2);
            MessageBox.Show(metin);
        
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            // Metniniz içerisindeki bir karakteri ya da bir bülümü yeni bir karakter - bölüm ile değiltirmesine olanak sağlar

            string ornekMetin = textBox7.Text;

            ornekMetin = ornekMetin.Replace("adam", "kadın");

            MessageBox.Show(ornekMetin);
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            // belirttiğiniz karakteri belirttiğiniz özel karakterlere göre parçalayarak ayrı parçalar haline getirir.

            string mailAdresleri = textBox8.Text;
            string[] mailler = mailAdresleri.Split(',', ';');

            foreach (var item in mailler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_subString_Click(object sender, EventArgs e)
        {
            //Tek parametre verilirse, metin içinde belirtilen index ile başlayarak geri kalan tüm kısmı çelip almanızı sağlar. Çift parametre
            //verilirse de başlangıç ve son index değerleri olarak algılar ve parçayı getirir.


            string subStr = textBox9.Text;
            subStr=subStr.Substring(3);
            MessageBox.Show(subStr);
            
        }

        private void btn_toCharArray_Click(object sender, EventArgs e)
        {
            //stringlerinizi charlarına ayırarak size char [] olarak teslim eder..
            int toplam = 0;
            string testmetini = textBox11.Text;
            char[] karakterler = testmetini.ToCharArray();

            for (int i = 0; i < testmetini.Length; i++)
            {
                toplam += testmetini[i];
            }
            listBox1.Items.Add((toplam));  
           
            // Örnek : dışarıdan girilen metinin her bir karakterinin ascii değerli toplamı nedir.
        }

        private void btn_Trim_Click(object sender, EventArgs e)
        {
            // Metninizin sağından ya da solundan boşlukların silinmesini sağlayan metotdur.

            string test = textBox12.Text;
            string test1 =textBox12.Text;

            test= test.Trim();
            MessageBox.Show(string.Format("Boşluklarla hesaplanan karakter sayısı {0} \n Buşluklar ,temizlenip hesaplanan karakter sayısı {1}", test1.Length, test.Length));

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

        }



        //Tolower
        //Toupper
    }
}
