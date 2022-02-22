using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternaryif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ternary Operatörü
        //Tek satırda ufak bir karar mekanizması ile kodunuza devam etmek isterseniz. Soru işareti operatörü bu pratikliği sağlar.
        //Yazılım formatı;
        //KontrolDEGER(KARŞILAŞTIRMA OPERATÖRÜ) ? Durumun olumlu olma durumu: "Durumun olumsuz durumu";
        private void Form1_Load(object sender, EventArgs e)
        {
            //string girilendeger = "Bilge Adam";
            //MessageBox.Show(girilendeger == "Bilge Adam" ? "doğru değer" : );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text.Length == 0 ? "DEFAULT": textBox1.Text);
        }
    }
}
