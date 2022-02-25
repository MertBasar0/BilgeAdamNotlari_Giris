using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;
        SoundPlayer spkc = new SoundPlayer(@"C:\Users\mertb\Source\Repos\MatematikselOperat-rler\HorseRacing\Resources\spiker-tek-attigi-ati-anlatirsa.wav");
        private void btn_baslat_Click(object sender, EventArgs e)
        {
            spkc.Play();
            if (timer1.Enabled==true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
            rnd = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bir kontrolün left propp'u o kontrolün sola olan uzaklığını size teslim eder.
            //Bir kontrolün left ve top özelliklerine atama yapabilirsiniz ancak right ve bottom özellikleri yalnızca o değeri alır.

            pcp_Horse1.Left += rnd.Next(5, 25);
            pcp_Horse2.Left += rnd.Next(5, 25);
            pcp_Horse3.Left += rnd.Next(5, 25);

            if (pcp_Horse1.Left>pcp_Horse2.Left && pcp_Horse1.Left>pcp_Horse3.Left)
            {
                label1.Text = "Birinci at önde";
            }
            else if(pcp_Horse2.Left>pcp_Horse1.Left && pcp_Horse2.Left >pcp_Horse3.Left)
            {
                label1.Text = "İkinci at önde..";
            }
            else if(pcp_Horse3.Left>pcp_Horse2.Left && pcp_Horse3.Left>pcp_Horse1.Left)
            {
                label1.Text = "Üçüncü at önde..";
            }

            //Bir kontrolün "Width" özelliği, kontrolün size genişliğini verecektir.
            //Kontrolün "Height" özelliği ise o kontrolün yüksekliğini verir.

            if (pcp_Horse1.Left+pcp_Horse1.Width>= btn_Finish.Left)
            {
                timer1.Stop();
                spkc.Stop();
                MessageBox.Show("Yarışı birinci kulvardaki at kazandı !!");
            }
            else if(pcp_Horse2.Left + pcp_Horse2.Width>= btn_Finish.Left)
            {
                timer1.Stop();
                spkc.Stop();
                MessageBox.Show("Yarışı ikinci kulvardaki at kazanmıştır !!");
            }
            else if (pcp_Horse3.Left + pcp_Horse3.Width>= btn_Finish.Left)
            {
                timer1.Stop();
                spkc.Stop();
                MessageBox.Show("Yarışı üçüncü kulvardaki at kazandı !!");
            }
        }

        private void btn_Sifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcp_Horse1.Left = 0;
            pcp_Horse2.Left = 0;    
            pcp_Horse3.Left = 0;
            label1.Text = String.Empty;
        }

        private void pcp_Horse1_MouseHover(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                pcp_Horse1.Left += 100;
            }
            
        }

        private void btn_BahisAl_Click(object sender, EventArgs e)
        {
            BahisAl bahis = new BahisAl();
            bahis.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
