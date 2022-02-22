using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSınıfı
{
    public partial class Form2 : Form
    {
        //dışarıdan girilen 3 sayıdan en küçüğünü tek satırda gösteriniz..
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            int deger;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            deger = Math.Min(Math.Min(sayi1, sayi2),sayi3);

            listBox1.Items.Add(deger.ToString()); 
        }
    }
}
 


