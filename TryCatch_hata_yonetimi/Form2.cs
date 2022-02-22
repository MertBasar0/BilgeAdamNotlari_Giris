using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch_hata_yonetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pow_Click_1(object sender, EventArgs e)
        {
            {
                //   int deger = Convert.ToInt32(textBox1.Text);
                //  int deger2 = Convert.ToInt32(textBox2.Text);

                //  double sonuc =Convert.ToDouble(Math.Pow(deger, deger2));

                //  MessageBox.Show("sonuc: "+sonuc);

                try
                {
                    double sonuc = Math.Pow(double.Parse(textBox1.Text), Convert.ToDouble(textBox2.Text));
                    notifyIcon1.Visible = true;
                    notifyIcon1.Text = sonuc.ToString();
                    notifyIcon1.BalloonTipTitle = "Sonucumuz";
                    notifyIcon1.BalloonTipText = sonuc.ToString();
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(10000);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
