using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Width = 30;
                pcb.Height = 30;
                pcb.Margin = new Padding(1);
                pcb.BackColor= Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                flowLayoutPanel1.Controls.Add(pcb);
            }
        }
    }
}
