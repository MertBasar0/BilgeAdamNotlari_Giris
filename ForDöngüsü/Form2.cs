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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Diziler_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ad ="mehmet";

            string[] Takimlar = {"Fenerbahçe" , "Galatasaray" , "Beşiktaş", "Trabzonspor"};
            for (int i = 0; i <= 3; i++)
            {
                listBox1.Items.Add(Takimlar[i].ToString());
               
            }
            
        }

        private void btn_diziler2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Sayısal bir dizi tanımlanyan array sınıfını kullanmadan o dizi içerisindeki en büyük elemanı bulunuz.
            int deger= 0;
            int[] Sayilar = { 12, 23, 34, 54, 65, 76, 687, 435, 345, 657, 789, 89 };

            for (int i = 0; i < Sayilar.Length; i++)
            {
                if (deger < Sayilar[i])
                {
                    deger = Sayilar[i];
                }
            }
            MessageBox.Show(deger.ToString());
            
        }

        private void btn_Ornek3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Aşağıdaki dizide kaç tane çift kaç tane tek sayı vardır. Kullanıcıyı bilgilendir.
            int[] Sayilar = { 12, 23, 34, 54, 65, 76, 687, 435, 345, 657, 789, 89 };

            int tek = 0;
            int cift = 0;

            for (int i =0 ; i < Sayilar.Length; i++)
            {
                if (Sayilar[i]%2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }

            }    
            listBox1.Items.Add(cift+\n+tek);
           
        }

        private void btn_diziler4_Click(object sender, EventArgs e)
        {
            //Aşağıda vermiş olduğum "adim" değişkeninde yer alan metni tersten ister formun text'ine isterneniz messageBox a yazdırınız.

            string kelime = "adim";
            string yeni="";
            listBox1.Items.Clear(); 
            for (int i = kelime.Length-1; i >=0; i--)
            {
                yeni+=kelime[i];
                
            }
            listBox1.Items.Add(yeni);
        }

        private void btn_Diziler5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            int sayi;
            
            for (int i = 0; i <= 50; i++)
            {
                sayi=random.Next(0, 200);
                listBox1.Items.Add(sayi);
            }
        }

        private void btn_ornek6_Click(object sender, EventArgs e)
        {
            //Form üzerinde yer alan butonları lacivert renk, yazı rengini sarı yap değiştir.
            //Eğer karar yapılarında değer kontrolü yapıyor iseniz . == != gibi operatörler kullanılır. Fakat nesneler üzerinde kontrol istiyorsanız 'is' keywordünü
            //kullanmanız gerekli.


           for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.AliceBlue;
                    this.Controls[i].ForeColor = Color.Red;
                }
            }
        }

        private void btn_diziler7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkBlue;
                    this.Controls[i].ForeColor = Color.Yellow;
                    this.Controls[i].Font=new Font("tahoma",13);
                }

                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Name= Name("");
                }

            }
        }
    }
}
