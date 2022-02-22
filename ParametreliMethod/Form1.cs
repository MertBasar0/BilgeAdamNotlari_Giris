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

namespace ParametreliMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void telno(string telno)
        {
            //Dışarıdan girilen telefon numaralarını ;,+ gördüğü yerde ayırıp listboxa dolduran bir method yazınız.

            string []telefonlar = telno.Split('.',',',';','+');
            listBox1.Items.AddRange(telefonlar);
 
        }
        void harfGetir(string kelime)
        {
            //Textbox'tan girilen kelimeni son 3 harfini getiren metot.

            string tersKelime = "";
            for (int i = kelime.Length-1 ; i >= kelime.Length-3; i--)
            {
                tersKelime += kelime[i];
            }
            MessageBox.Show(tersKelime);
        }
        void arkaPlan(string renk)
        {
            //ComboBox'dan seçilen rengi formun arkaplan rengi olarak ayarlayan bir method yazınız.
            this.BackColor = Color.FromName(renk);
        }

        //Dışarıdan girilen iki sayının toplamının küpünü messagebox'la gösterecek bir method yazınız.
        void toplaminkubu(int sayi1, int sayi2)
        {
            MessageBox.Show(Math.Pow((sayi1 + sayi2), 2).ToString());
        }

        void parametreliSaydir(int sayi)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btn_void1_Click(object sender, EventArgs e)
        {
            parametreliSaydir(500);
        }

        private void btn_void2_Click(object sender, EventArgs e)
        {
            toplaminkubu(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arkaPlan(comboBox1.SelectedItem.ToString());
        }

        private void btn_void3_Click(object sender, EventArgs e)
        {
           harfGetir(textBox3.Text);
        }

        private void btn_void4_Click(object sender, EventArgs e)
        {
            telno(textBox4.Text);
        }
    }
}
