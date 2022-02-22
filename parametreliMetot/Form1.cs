using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametreliMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Dışarıdan girilen telefon numaralarını ;,+ gördüğü yerde ayırıp listboxa dolduran bir method yazınız.

        #region voids


        void parcala(string tel)
        {
            if (textBox1.Text != "")
            {
                string[] parcalar = tel.Split('.', ':', ';', ',');

                foreach (var item in parcalar)
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        void harfGetir(string kelime)
        {
            //Textbox'tan girilen kelimeni son 3 harfini getiren metot.
            if (textBox1.Text != "")
            {
                string ters = "";
                kelime = kelime.ToLower();
                for (int i = kelime.Length - 1; i >= kelime.Length - 3; i--)
                {
                    ters += kelime[i];
                }
                MessageBox.Show(ters, "tersten üç harf");
            }

        }

        void tadilatci(ComboBox comboBox)
        {
            //ComboBox'tan seçilen rengi formun arkaplan rengi olarak ayarlayan bir metot yazınız.
            if (comboBox.SelectedItem != null)
            {
                Color renk = Color.FromName(comboBox.SelectedItem.ToString());
                this.BackColor = renk;
            }
        }


        void toplamınKupu(int sayi1,int sayi2, out double sonuc)
        {
            //Dışarıdan girilen iki sayının toplamının küpünü listbox'ta gösterecek bir method yazınız.
            sonuc = Math.Pow((sayi1 + sayi2), 2);
        }

        #endregion



        private void btn_telParcala_Click(object sender, EventArgs e)
        {
            parcala(textBox1.Text);
        }


        private void btn_terstenUc_Click(object sender, EventArgs e)
        {
            harfGetir(textBox1.Text);
        }


        private void btn_arkaPlanıDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                tadilatci(comboBox2);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir sorun oluştu..");
            }          
        }

        private void btn_toplamınKupu_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            toplamınKupu(Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text),out sonuc);
            listBox1.Items.Add(sonuc);

        }
    }
}
