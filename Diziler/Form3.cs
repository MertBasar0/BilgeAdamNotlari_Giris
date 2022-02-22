using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] sehirler = { "ankara", "istanbul", "izmir", "sivas", "bursa", "eskişehir", "malatya" };
       

        private void btn_birOrnek_Click(object sender, EventArgs e)
        {
            foreach (var sehir in sehirler)
            {
                //sehir diye adlandırdığımız değişken, dongünün devam edebilmesi için yardımcı araçtır.
                //herhangi bir değeri yoktur.
                listBox1.Items.Add(sehir);
                //ilgili dizi içerisindeki her elemanı size "sehir" takma adı ile verir. ve döngünün her adımında size dizinin bir elemanını teslim edecektir.
                //listBox1.Items.AddRange(sehirler);
            }

        }

        private void btn_ornek3_Click(object sender, EventArgs e)
        {
            //listbox2.Items.Add(listbox1.SelectedItem);

            foreach (var item in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(item))
                {
                    listBox2.Items.Add(item);
                }
            }
        }

        private void btn_ornek4_Click(object sender, EventArgs e)
        {
            //Form üzerinde tüm butonların arkaplan ve yazı rengini değiştiriniz.

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Maroon;
                    ctrl.ForeColor = Color.Red;
                }
            }
        }
        //Foreach 
        //Kesinlikle index mantığı yoktur.
        //tip bağımlı döngülerdir.
        //Çoğu zaman elimizdeki bir koleksiyonun her birini tek tek ele almak için kullanılır.




    }
}
