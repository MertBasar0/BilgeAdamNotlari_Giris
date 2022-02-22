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

namespace arrayListOrneklerTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ary = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ary.Add("sad");
            ary.Add("bad");
            ary.Add("dad");
            ary.Add("kat");
            ary.Add(4);
            ary.Add(7);
            ary.Add(9);

        }

        private void btn_diziyiGetir_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox1.Text); 
            listBox1.Items.Add(ary[index]);
        }

        private void btn_diziToplam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in ary)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btn_elemanSil_Click(object sender, EventArgs e)
        {
            int index = ary.IndexOf(textBox1.Text);
            ary.RemoveAt(index);
            ary.TrimToSize();
            
        }
    }
}
