using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDöngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Döngüler - loops
        //Bir başlangıç  değeri olan belirli koşul gerçekleşene dek süren ve bu süre içerisinde bir takım işlemleri tekrarlı olarak gerçekleştiren nesnelere doğru adını vermekteyiz.
        
        //For- Foreach- While_ Do while 
        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //DÖngü ilk giriş anında derleyici başlangıç değerine bakar ve bir daha asla bu bloğa uğramaz.
            //Bundan sınraki işlemler önce arttır, daha sonra koşula bak, koşul uygunsa döngünün kod bloğunu harekete geçir, uygun değilse döngüden çıkar.
            //(başlangıçDeğeri;bitişKoşulu;artış veya azalış miktarı)
            for (int deger = 0; deger < 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int deger = 1000; deger >= 0; deger--)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void btn_Ornek3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //2'den başlatıp 1000'e kadar 2şer arttırarak çift sayıları alma.
            for (int i = 2; i <= 1000; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Ornek4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //1-1000 arasındaki sayıların toplamını ekrana bastırınız..
            //for (int i = 1; i<= 1000; i=i++)
            //{
            //    listBox1.Items.Add(i);
            //}
            int kutu = 0;
            for (int i = 0; i <= 1000; i++)
            {
                kutu += i;
            }
            //MessageBox.Show(kutu.ToString());
            MessageBox.Show($"toplam=>{kutu}");
        }

        private void btn_Ornek5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Alfabetik olarak a-z ye sıralama yapınız..

            for (char i = 'A'; i <= 'Z'; i++)
            {
                //listBox1.Items.Add(i+"-"+Convert.ToUInt32(i));
                listBox1.Items.Add($"{i}---{Convert.ToInt32(i)}");
            }
        }

        private void btn_Ornek6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //1-100 arasındaki çift sayıalrın toplamı ile, tek sayıların toplamının farkları karesi kaçtır.
            int tekToplam = 0;
            int çiftToplam = 0;
            double sonuc=0;
            //for (int deger1 = 1; deger1 <= 100; deger1+=2)
            //{
            //    tekToplam += deger1;
            //}
            //for (int i = 2; i <= 100; i+=2)
            //{
            //    çiftToplam += i;
            //}
            //sonuc = Math.Pow(Convert.ToDouble(çiftToplam - tekToplam), 2);
            //MessageBox.Show(sonuc.ToString());
            

            for (int deger1 = 1; deger1 < 100; deger1+=2)
            {
                tekToplam += deger1;
            }
            for (int deger2 = 2; deger2 < 100; deger2+=2)
            {
                çiftToplam += deger2;
            }
            sonuc = Math.Pow((çiftToplam - tekToplam), 2);
            MessageBox.Show(sonuc.ToString());

        }

        private void btn_Ornek7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1945; i <= 2022; i++)
            {
                if(i!=1990 && i!=1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
