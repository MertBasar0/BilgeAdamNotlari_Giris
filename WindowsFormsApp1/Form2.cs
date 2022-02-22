using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Toplam_Click(object sender, EventArgs e)
        {
            //int sayiBir = 102;
            //int sayiIki = 25;
            //int toplam = sayiBir + sayiIki;

            ////Sayıda toplam değişkenini string'e  çevirmeden yazdığımız halde derleyicinin bize kızmamasının sebebi "implicit convert" dediğimiz olaydır.
            ////Yani eğer bir toplama işleminde string varsa geriye kalan tüm değerler otomatik olarak stringe çevrilir.


            //MessageBox.Show("Toplam sonucu= " + toplam);
            //MessageBox.Show("Toplam sonucu= " +(sayiIki + sayiIki));
            //MessageBox.Show("Toplam sonucu= " + sayiBir + sayiIki);

            int sayi1 = Convert.ToInt32( txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32( txt_Sayi2.Text);

            int toplam = sayi1 + sayi2;

            MessageBox.Show("toplam sonucu= "+toplam);
            txt_Sayi1.Clear();
            txt_Sayi2.Clear();


        }
        private void btn_Çıkar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);

            int Fark = sayi1 - sayi2;

            MessageBox.Show("İşlem sonucu= " + Fark);
            txt_Sayi1.Clear();
            txt_Sayi2.Clear();
        }

        private void btn_Çarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);

            int Carpım = sayi1 * sayi2;

            MessageBox.Show("İşlem sonucu= " + Carpım);
            txt_Sayi1.Clear();
            txt_Sayi2.Clear(); 
        }

        private void btn_Böl_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);

            int Bolum = sayi1 / sayi2;

            MessageBox.Show("İşlem sonucu= " + Bolum);
            txt_Sayi1.Clear();
            txt_Sayi2.Clear();
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);

            int Mod = sayi1 % sayi2;
            
            MessageBox.Show("İşlem sonucu= " + Mod);
            txt_Sayi1.Clear();
            txt_Sayi2.Clear();

        }

        private void btn_Ornek_Click(object sender, EventArgs e)
        {

            //// Parse() metodu
            ////Yalnızca string değerleri diğer veri tiplerine dönüştürmek için kullanılır. Herhangi bir veri tipini stringe çeviremez. 
            //string deger = "50";
            //int deger1 =




            //// TryParse()
            //string deger2 = "50";
            //int sonuc = 0;
            //bool oldumu = int.TryParse(deger, out sonuc);
            //MessageBox.Show(oldumu.ToString() + sonuc);
        }
        private void btn_topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(nud_Sayi1.Value);
            int sayi2 = Convert.ToInt32(nud_Sayi2.Value);

            int toplam = sayi1 + sayi2;


            //MessageBox.Show("işlemin sonucu= " + toplam);

            Lbl_text.Text = toplam.ToString();

            
        }
    }
}
