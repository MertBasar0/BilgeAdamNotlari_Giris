using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genericListTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ternaryif_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("istanbul");
            sehirler.Add("adana");
            sehirler.Add("edirne");
            sehirler.Add("sivas");
            sehirler.Add("burdur");
            sehirler.Add("ankara");


            sehirler.ForEach(x => listBox1.Items.Add(x));

        }

        private void btn_contains_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("istanbul");
            sehirler.Add("adana");
            sehirler.Add("edirne");
            sehirler.Add("sivas");
            sehirler.Add("burdur");
            sehirler.Add("ankara");

            bool bul = sehirler.Contains(textBox1.Text);
            MessageBox.Show(bul ? $"{textBox1.Text} şehri listede var." : $"{textBox1.Text} şehri listede yok..");
        }

        List<int> sayisalDizi = new List<int> { 2, 3434, 345, 456, 678, 789, 890, 54, 456, 575, 234 };

        List<int> sayisalDizi2 = new List<int> { };
        private void btn_sayisalDizi_Click(object sender, EventArgs e)
        {
            
            int max =sayisalDizi2.Max();
            int min = sayisalDizi2.Min();

            MessageBox.Show($"en yüksek = {max} en düşük = {min}");
        }

        private void btn_elemanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                sayisalDizi2.Add(Convert.ToInt32(textBox2.Text));
                foreach (var item in sayisalDizi2)
                {
                    listBox1.Items.Add(item);
                }

                textBox2.Clear();
                textBox2.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("bir hatayla karşılaşıldı...");
            }
           

        }
        int[] sayiDizisi = new int[0];
        int index = 0;
        private void btn_reSize_Click(object sender, EventArgs e)
        {
           
            

            int eleman = Convert.ToInt32((textBox2.Text).Trim());
            Array.Resize(ref sayiDizisi, sayiDizisi.Length + 1);
            sayiDizisi[index] = eleman;
            listBox1.Items.Add($"{index}--{sayiDizisi[index]}");
            index++;

        }
    }
}
