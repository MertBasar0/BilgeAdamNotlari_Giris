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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox3.Text = string.Empty;
            textBox4.Text = null;
            textBox5.Text = default(string);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
