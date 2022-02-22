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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void donustur()
        {
            //Butona her basıldığında formun arkaplan rengini ve boyutlarını değiştirecek bir metod yazınız.
            //Arkaplan rengi beyaz, formun boyutu 400,400 olsun.

            this.BackColor = Color.White;
            this.Size = new Size(500, 500);
        }

        public void saydırıcı()
        {
            for (int i = 0; i <= 1000; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            saydırıcı();
        }

        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            donustur();
        }
    }
}
