using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutRefKeywordu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Out Anahtar kelimesi
        //Bir nethod içerisinde dışarıya birden fazla değer döndürmek isteyebilirsiniz "return" anahtar
        //kelimesi fonksiyonlarda size yetmeyecektir. Void method ise zaten geriye değer döndürmezler.
        //Bu bilineleri yıkmak için kullandığımız anahtar kelime


        void geriyeDegerDonen(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi, 2);

        }
        void hesapla(int sayi1, int sayi2, out int toplam, out int carpım, out double bolum, out int cıkarma, out double mod)
        {
            //Sizden geriye değer dönmeyen bir hesapla methodu yazmanı istiyorum.. iki sayı alacak ve dışarıya toplam beş adet sonuc dönecek
            //toplam,fark,çarpım,bölüm,mod
            toplam = sayi1 + sayi2;
            carpım = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            cıkarma = sayi1 - sayi2;
            mod = sayi1 % sayi2;
        }
        void listboxElemanlarıTemizle(ListBox hangilistbox, out int kac)
        {
            kac = hangilistbox.Items.Count;
            listBox1.Items.Clear();
        }


        #region Params Keyword,
        //Dışarıdan methoda kaç parametre geleceği bilinmemektedir.
        //Ancak gelecek olan tüm parametrelerle bir takım işler yapmak zorundasınız..
        //Bu sayısız parametre tutma yolu params anahtar kelimesinde geçer..
        //Params sizden bir dizi ister..




        //Ref Keyword

        //ref parametre niteleyicisi c#'ın "değer olarak çağrı" yerine "referans olarak çağrı oluşturmasını sağlar"
        //Ref kullanarak void tipli methodlardan değer alabilirsiniz. Üstelik bu değeri alabilmek için yeni bir değişken atamanıza gerek yoktur.
        //Ref, methoda parametre olarak soktuğunuzi elinizde varolan değişkenin değerini değiştirebilir.

        void mailListeleyici (ref string [] hangiDiziyeEklensin, string verilerNeredenGelecek)
        {
            string[] gelenDegerler = verilerNeredenGelecek.Split(';');
            for (int i = 0; i < gelenDegerler.Length; i++)
            {
                Array.Resize(ref hangiDiziyeEklensin, hangiDiziyeEklensin.Length + 1);
                hangiDiziyeEklensin[i] = gelenDegerler[i];
            }
        }


        // örnekler => dizi, string, classlar, arrayler, list

        double fiyatlariHesapla(params double [] fiyatlar)
        {
            double toplamTutar = 0;
            foreach (var item in fiyatlar)
            {
                toplamTutar += item;
            }
            return toplamTutar;
        }

        #endregion

        #region Recursive

        // bir fonksiyonun
        //Recursive
        private int Faktoriyel(int sayi)
        {
            int fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            return fak;
        }

        //Recu versiyon

        private int Fakt_recu(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
                return sayi * Fakt_recu(sayi - 1);
            }
        }

        void clean(Control.ControlCollection cls)
        {
            foreach (Control item in cls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        void temizle(Control.ControlCollection cls)
        {
            foreach (Control item in cls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is GroupBox)
                {
                    GroupBox grb = (GroupBox) item;
                    temizle(grb.Controls);
                }
            }
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            double yakalanSonuc;
            geriyeDegerDonen(12, out yakalanSonuc);
            MessageBox.Show(yakalanSonuc.ToString());

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int toplam=0;
            int carpma=0;
            double bolme=0;
            int cıkarma=0;
            double mod=0;

            hesapla(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),out toplam,out carpma, out bolme,out cıkarma,out mod);
            MessageBox.Show($"{toplam}  ,   {carpma}   ,   {bolme}    ,  {cıkarma}  ,   {mod}","test",MessageBoxButtons.OKCancel);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            int kac = 0;
            listboxElemanlarıTemizle(listBox1, out kac);
            MessageBox.Show($"silinen eleman =  {kac}","test",MessageBoxButtons.OKCancel);
        }

        private void btn_toplamıGöster_Click(object sender, EventArgs e)
        {
            double [] secilenler = {1123,123,123,345,456,6578,6758,45,6346,234 };
            
        }

        private void btn_mailListele_Click(object sender, EventArgs e)
        {
            int kac=0;
            listboxElemanlarıTemizle(listBox1, out kac);


            string[] elemanlar = new string[0];

            mailListeleyici(ref elemanlar, textBox3.Text);
            foreach (var item in elemanlar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {
            //int sonuc = Faktoriyel(5);
            //MessageBox.Show(sonuc.ToString());

            int sonuc = Fakt_recu(Convert.ToInt32(textBox4.Text));
            MessageBox.Show(sonuc.ToString());

            for (int i = 1; i <= 100; i++)
            {
                if (i%2!=0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }

      



       
    }
}
