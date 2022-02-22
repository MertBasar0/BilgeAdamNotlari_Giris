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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd;
        const int hak=5;
        //int sonuc;
        public void Yap()
        {
            int rasgele = rnd.Next(99999999);
            label1.Text = rasgele.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //Rasgele sayı üretmek için kullandığımız sayı üretmek ile görevli olan sınıfın adı Random.

            //rnd = new Random();

            //int rasgeleuretilensayi= rnd.Next(50);
            //int rasgele2 = rnd.Next(Min,Max);
            //=> Değer aralığı da verilerek yapılabilir. Max değerin bir altına kadar üretir.
            //int rasgele2 = rnd.Next(20,50);
            //MessageBox.Show(rasgeleuretilensayi.ToString());
            rnd = new Random();
            
            label2.Text = hak.ToString();
            Yap();
            
        }
        private void btn_RndSayi_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == label1.Text)
            {
                MessageBox.Show("Giriş yaptınız");
            }
            else
            {
                Yap();
                hak-=1;
                
                label2.Text=hak.ToString();
            }
        }

        //formun açılış anında 8 haneli rastgele bir sayı label'a yazdırılsın ve kullanıcı butona bastığı and textbox da ki yazıyla labelda ki yazının karşılaştırılması yapılsın. Eğer karşılaştırma olumsuz ise lblkalanhakkımız labılındaki değer bir azalacak. Eğer kullanıcı 5 defa hatalı giriş yaparsa butonun aktifliğini kapatın. her hatalı girişte rasgele yeni sayı üretmelisiniz.
    }
}
