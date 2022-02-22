using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methodNedirTekrar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Butona her basıldığında formun arkaplan rengini ve boyutlarını değiştirecek bir metod yazınız.
        //Arkaplan rengi beyaz, formun boyutu 400,400 olsun.

        void degistir()
        {
                this.BackColor = Color.Black;
                this.Height = 300;
                this.Height = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            degistir();
        }
    }
}
