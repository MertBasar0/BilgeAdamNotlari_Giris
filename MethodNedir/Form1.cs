using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodNedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = null;
            textBox4.Text = String.Empty;
            textBox5.Text = default(string);

        }
        //Geriye değer döndürmeye (void) methodlar, yalnızca üzerine düşen işi yaparlar, subrutinler.
        //Tekrar kodlarının önüne geçmeyi engellemek.
        //Kod kalabalığından kurtulup daha esnek kodlar yazabilmek.
        //Merkeziyetci bir yönetim yapısından dolayı herhangi bir problem ya da değişiklik olduğu durumda birden fazla yeri kontrol etmek yerine,
        //merkez yapıya müdahale ederek en kısa ve net şekilde sorunu çözebilirsiniz.

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
