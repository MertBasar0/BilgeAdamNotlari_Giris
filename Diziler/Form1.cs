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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Array-dizi
        //Birden fazla değeri tek bir değişende tutmanız zordur.. dizi tipi tanımlayarak aynı değişken tipindeki tipleri kullanarak dizinin tipini belirler.
        //Eğer şu hata alınıyor ise ; Index was outside the bounds of the array.
        // Bilin ki dizinin boyutları aşılacak şekilde eleman eklemye çalışıyorsunuz..

        

        private void button1_Click(object sender, EventArgs e)
        {
            //1. tanımlama yöntemi;
            int[] dizi = new int[3];
            dizi[0] = 0;
            dizi[1] = 1;
            dizi[2] = 2;
            //dizi[3] = 3;  dizinin eleman sayısını aştığı eleman..


            //2. tanımlama
            //veritipi [] diziadi = new veritipi [] {};
            string [] sehirler = new string[4]
            {
                "izmir","istanbul","ankara","manisa"
            };
            this.Text = sehirler[2];

            //3.tanımlama yontemi
            //veritipi [] diziadi = {dizielemanları};
            char[] karakterler = { 'a', 'b', 'c', 'd' };
            

        }
    }
}
