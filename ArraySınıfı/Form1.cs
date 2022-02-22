using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ornekDizi = { "istanbul", "ankara", "izmir", "bursa", "eskişehir", "konya", "trabzon", "sivas","istanbul" };
        private void btn_Array1_Click(object sender, EventArgs e)
        {
            //Array.Clear(); => diziden eleman silmek için kullanılan metotdur.


            //1. parametre kaynakdizi.
            //2. parametre başlangıç index değeri.
            //3. parametre silinecek eleman sayısı alacaktır.
            Array.Clear(ornekDizi, 0, ornekDizi.Length);

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            string[] yeniSehirler = new string[4];

            Array.Copy(ornekDizi, yeniSehirler, 4);
            //1.parametre kaynak dizi
            //2.parametre hedef dizi
            //3.parametre kaynak diziden hedef diziye kaç eleman kopyalanacak.
        }

        private void btn_copy2_Click(object sender, EventArgs e)
        {
            string[] yeniSehirler = new string[4];
            Array.Copy(ornekDizi, 3, yeniSehirler, 1, 1);
            //1.parametre kaynak dizi.
            //2.parametre kaynak dizinin kaçıncı index değerinde kopyalamaya başlayacak.
            //3.parametre hedefdizi
            //4.parametre hedef dizinin kaçıncı index değerinden ek lemeye başlayacak.
            //5.parametre hedef dizi kaç eleman kopyalayacak..
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Array indexof() =>> dizide aradığınız elemanın index numarasını döndüren metotdur.
            //Eğer aradığınız değer dizi içerisinde değilse -1. Eğer eleman dizide birden fazla defa geçiyor ise i.
            
            
            int bulunanindex = Array.IndexOf(ornekDizi, textBox1.Text);
            if (bulunanindex == -1)
            {
                MessageBox.Show("aranan eleman dizide bulunmamaktadır.");
            }
            listBox1.Items.Add(bulunanindex.ToString());


            //1.parametre kaynak dizi
            //2.parametre aranılacak nesne(object tipinde olduğu için veri ister dizinin tipinde o tipte olmasada farklı tipte olması farketmeyecektir.)

            //2.Yol
            //MessageBox.Show(bulunanindex < 0 ? "Aradığınız eleman dizi içerisinde yoktur." : "Aradığınız elemanın index değeri= " + bulunanindex);

            bulunanindex = Array.IndexOf(ornekDizi, textBox1.Text, 5);
            //1.parametre kaynak dizi
            //2.parametre aranılacak nesne(object tipinde olduğu için veri ister dizinin tipinde o tipte olmasada farklı tipte olması farketmeyecektir.)
            //3.parametrede aramaya kaçıncı iindex'den başlanacağı söylenir.
            //4.parametre başlanılacak index değerinin sonraki kaç eleman içerisinde arama yapılacağını belirtir.

            //LastIndexof'da dizide indexlemede bir değişiklik yoktur. Sadece sondan bakmaya başlar. Bulduğu anda indexi döndürür ve metot görevini tamamlar.
            //int aranılanindex = Array.LastIndexOf(ornekDizi, "ankara");
        }

        private void btn_tekrarEdenDeğerler_Click(object sender, EventArgs e)
        {
            //bir dizide bir elemanın birden fazla olup olmama durumunu kontrol ediniz.
            int tekrarDeger = Array.IndexOf(ornekDizi, "istanbul");

            if (Array.IndexOf(ornekDizi,"istanbul")==Array.LastIndexOf(ornekDizi,"istanbul"))
            {
                this.Text = "Aradıpınız değer tekrar etmiyor..";
            }
            else
            {
                this.Text = "bu dizide aradığınız değer birden fazla bulunmaktadır..";
            }
            
            

        }

        private void btn_reSize_Click(object sender, EventArgs e)
        {
            Array.Resize(ref ornekDizi, 23);
        }
    }
    //Array Sınıfı
    //Su ana dek görmüş olduğumuz ilkel diziler, bize üzerinde çok fazla işlem yapma olanağı sağlamamaktadır.
    //Eğer dizini yeniden boyutlandırmak, temizlemek, sıralamak,ters çevirmek gibi temel işlemleri yapmak isterseniz array sınıfını kullanmalısınız. 
}
