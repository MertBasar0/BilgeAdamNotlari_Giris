using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class HACK : Form
    {
        public HACK()
        {
            InitializeComponent();
        }

        private void btn_Hack_Click(object sender, EventArgs e)
        {
            Form1 yaris2 = new Form1();
            yaris2.Show();
            this.Hide();
          
        }
    }
}
