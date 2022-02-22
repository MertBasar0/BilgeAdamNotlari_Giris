using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeMayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> mayinlar = new List<int>();
            //Oluşturduğumuz nesneler için toplamda 20 adet mayın belirleyiniz.
            //Rastgele belirlenen 20 sayısı, oluşan numaralara göre pcb'lere mayın atayalım.

            for (int i = 0; i <= 50; i++)
            {
                int mayin = rnd.Next(0, 560);
                if (!mayinlar.Contains(mayin))
                {
                    mayinlar.Add(mayin);
                }
                else
                {
                    i--;
                }              
            }
            
            for (int i = 0; i < 560; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Name = "pcb" + i;
                pcb.Width = 30;
                pcb.Height = 30;
                //pcb.Size = new Size(); kullanılabilir.
                pcb.Margin = new Padding(1);
                pcb.BackColor = Color.FromArgb(rnd.Next(0,256), rnd.Next(0,256), rnd.Next(0,256));


                //i'nin o anki değeri mayınlar listesinde yer alıyor ise, bir durum bildirmemiz gerekli.

                if (mayinlar.Contains(i))
                {
                    pcb.Tag = true;
                }
                else
                {
                    pcb.Tag = false;
                }

                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);
                
            }
            timer1.Start();
            timer1.Interval = 200;


        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            Color background = pcb.BackColor;

            if ((Boolean)pcb.Tag==true)
            {
                timer1.Stop();
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    pcb = (PictureBox)item;
                    pcb.BackColor = background;
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

                  
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    PictureBox pb = (PictureBox)item;
                    pb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                }
          
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
      
        }
    }
}
