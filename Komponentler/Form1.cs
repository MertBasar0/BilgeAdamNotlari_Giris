using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponentler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int karaktervaruzerinde =textBox1.Text.Length;
            int fark = 450 - karaktervaruzerinde;
            label1.Text= fark.ToString();
        }
        //Üzerinden ayrıldığı anda arkaplan yazı rengini siyah yapın..

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_MouseLeave_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Red;
        }
        //Fare alana girdiği anda, textbox'un yazı rengi ve arkaplanı değiştir.


    }
}
