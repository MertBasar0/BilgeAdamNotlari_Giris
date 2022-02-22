using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_while1_Click(object sender, EventArgs e)
        {
            //Form üzerinde yer alan tüm kontrellerin geişliklerini 100 px olarak ayarlayalım ve
            //yukarıya doğru olan uzunlukluklarını 20 px arttıralım.. //top //width //button
            int  i= 0;
            while (i < this.Controls.Count)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Top += 20;
                    this.Controls[i].Width += 100;

                   
                }
                i++;
            }
        }
    }
}
