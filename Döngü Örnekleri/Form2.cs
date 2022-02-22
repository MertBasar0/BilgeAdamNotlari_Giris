using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngü_Örnekleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int sayi = int.Parse(textBox1.Text);
            //for (int i = 1; i < sayi; i++)
            //{

            //    dizi = new int[i];

            //}
            //listBox1.Items.Add(dizi);
            int sayi = Convert.ToInt32(textBox1.Text);
                if (textBox1.Text != "")
                {
                    textBox2.Text = "";

                    for (int i = 2; i < sayi; i++)
                    {
                        bool asalmi = true;
                        for (int j = 2; j <= i / 2; j++)
                        {
                            if (i % j == 0)
                            {
                                asalmi = false;
                            }
                        }



                        if (asalmi == true)
                        {
                            textBox2.Text += i + Environment.NewLine;
                        }



                    }

                }
            }



            //ikisayiArasındakiAsalSayilari bulalım. 
        }
    }

