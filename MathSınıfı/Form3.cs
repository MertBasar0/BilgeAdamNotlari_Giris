using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSınıfı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_startStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, imgList.Images.Count);
            pcbResim.Image = imgList.Images[index];

            //Anlık olarak index-değeri tag prop üzerinden tutuyorum.
            //Nedeni bu kısımda nesnenin kendisini taşıyacağım bir yanlışlık olma ihtimalini ortadan kaldırıyorum.

            pcbResim.Tag = index;
        }
         
        private void btn_last_Click(object sender, EventArgs e)
        {
            pcbResim.Image = imgList.Images[imgList.Images.Count - 1];
        }

        private void btn_firs_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbResim.Image = imgList.Images[0];
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = (int)pcbResim.Tag;
            index--;

            if (index < 0)
            {
                index = imgList.Images.Count - 1;
                pcbResim.Image = imgList.Images[index];
            }
            else
            {
                pcbResim.Image = imgList.Images[index];
            }
            pcbResim.Tag = index;
           
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = (int)pcbResim.Tag;
            index++;

            if (index > imgList.Images.Count-1)
            {
                index = 0;
                pcbResim.Image = imgList.Images[index];
            }
            else
            {
                pcbResim.Image = imgList.Images[index];   
            }
            pcbResim.Tag = index;
        }

       
    }
}
