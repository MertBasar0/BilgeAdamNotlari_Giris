using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ornek3_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Edirne");
            sehirler.Add("Istanbul");
            sehirler.Add("Eskişehir");
            sehirler.Add("Bursa");

            //Dizinin elamanlarını küçükten büyüğe sıralar..
            sehirler.Sort();

            sehirler.ForEach(x => listBox1.Items.Add(x));
        }

        private void btn_Ornek4_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Edirne");
            sehirler.Add("Istanbul");
            sehirler.Add("Eskişehir");
            sehirler.Add("Bursa");

            //Edirne eğer liste içerisinde yer alıyor ise => edirne yer almaktadır diye bir mesaj versin yok almıyor ise bildirdiğiniz şehir bulunamadı..

            MessageBox.Show(sehirler.Contains("Edirne") ? "sehirler dizisi içerisinde edirne ili yer almaktadır.." : "Edirne yer almamaktadır..");

           
        }

        private void btn_Ornek5_Click(object sender, EventArgs e)
        {
            //İçeriğine sizin karar vereceğiniz bir sayısal dizi oluşturunuz ve bu dizinin en küçük en büyük elemanını bulup
            //messagebox'da gösteriniz..

            int[] dizi = {123,34,56,78,500,87,90,435 };
            int max = 0;
            int min = 999999;
            foreach (var item in dizi)
            {
                if (item >max)
                {
                    max =item;
                   
                }
                if (item <= min)
                {
                    min = item;
                }


            }
            MessageBox.Show("enbüyük=" + max + "enküçük=" + min);
        }
        string[] kayit = new string[0];
        int index = 0;
        private void btn_Ornek6_Click(object sender, EventArgs e)
        {
            //Textbox'dan girilen veri kayıtlar listesine eklensin her yeni kayıt dizininin sınırlarını değiştirsin.
            //Elemanlar eklendikten sonra listbox^da gösteriniz..
            //format => eleman index--- eleman 
            string eleman = textBox1.Text;
            Array.Resize(ref kayit, kayit.Length + 1);
            kayit[index] = eleman;
            
            index++;
            listBox1.Items.Add($"{index}-- {eleman}");
        }
    }
}
