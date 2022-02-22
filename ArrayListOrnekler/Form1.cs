using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListOrnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //klasik dizi tanımlamalarını unutabiliriz.
        //Tip bağımlı ve eleman sayısının zorunluluğu sıkıntılı bir durumdu.
        //Ancak arrayList nesnesi ile birlikte bu bağımlılıklar ortadan kayboldu..
        //Bir arraylist oluştururken ne bir değer aralığı vermek zorundasınız ne de bir tip.

        //Dezavantajları nelerdir??
        //Arraylist içerisindeki elemanları otomatik olarak object veri tipinde döndürme özelliğine sahiptir.
        //Dolayısıyla bu verileri geri almak istediğinizde mecburen bir "cast" yada cnovert" işlemine gerek duymaktasınız..
        //Bu da ekstra iki kat iş demek (object => unboxing işlemi uygulanır..)

        //Arraylist'i kullanabilmek için namaspace' lere using system.collections; ibaresi eklenmelidir.
        ArrayList ary = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            x.Text = "Test";
            ary.Add(5);
            ary.Add("5");
            ary.Add(true);
            ary.Add(x);
            //Eğer bir nesnenin ram'de heap alanına direkt ulaşmaya çalışıyorsanız ulaşamazsınız.
            //Bu alana girmek için bir tane referans tutucuya ihtiyacınız vardır.

            ary.Add("istanbul");
            ary.Add("ankara");
            ary.Add("izmir");
            ary.Add("manisa");
            ary.Add("antalya");
            ary.Add("gaziantep");
        }
        //Metodlar;
        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            //this.Text = (string)ary[0];
            //Form fr =(Form)ary[3];
            //MessageBox.Show(fr.Text);

            //Dizinin eleman sıyısına nasıl ulaşırız:

            this.Text=ary.Count.ToString();

            //Dizideki elemanın indexini nasıl alırım
            this. Text = ary.IndexOf("izmir").ToString();

            this.Text = ary.LastIndexOf("izmir").ToString();

            //Araya eleman ekleme..
            ary.Insert(3, "malatya");

            //İstenilen değeri silme

            ary.RemoveAt("izmir");

            //Sıralama

            ary.Sort(); 

            // tersçevirme
            
            ary.Reverse();

            //o an ki kapasiteyi, o an ki elaman sayısına eşitleme
            ary.TrimToSize();

            //dizi temizleme

            ary.Clear();


        }
    }
}
