using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool tekCift(int sayi)
        {
            if (sayi % 2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btn_systemIO2_Click(object sender, EventArgs e)
        {
            //bool sonuc = Directory.Exists(@"C:\\test2"); //Klasör var ise true, yok ise false döner.


            //if (sonuc)
            //{
            //    Directory.Delete(@"C:\\test2"); //Klasör boş ise silecek.
            //}
            //else
            //{
            //    Directory.CreateDirectory(@"C:\\test2"); //boş klasör ekler..
            //}

            string[] dizi = Directory.GetDirectories(@"C:\\test2"); //Verilen yolda bulunan klasörleri getirir.

            foreach (string d in dizi)
            {
                listBox1.Items.Add(d);
            }

            string[] dizii = Directory.GetFiles(@"C:\\test2");  //Verilen yoldaki bütün dosyaları getirir.

            foreach (var item in dizii)
            {
                listBox1.Items.Add(item); //Verilen yoldaki dosyaları getirir.
            }

            string root = Directory.GetDirectoryRoot(@"C:\\test2");
            MessageBox.Show(root); //Dosyanın ana dizini döner.

            Directory.Move(@"C:\\test2", @"C:\\Ios"); // Var olan dosyayı silip verilen yolda bir dosya oluşturarak içeriği kopyalar.

        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            // File: STATİC BİR DOSYA KONTROL SINIFIDIR. DIRECTORY İLE ÇOĞU AYNI METOTLARA SAHİP OLMASINA RAĞMEN
            //file => dosyalarda .Directory =>> klasörlerde kullanılır..

            #region Dosya Yazma ve oluşturma olayları

            //FileStream fs = File.Create(@"C:\\Ios\\test.txt");
            //MessageBox.Show(fs.Name);

            //byte[] metin = new UTF8Encoding(true).GetBytes("merhaba arkadaşlar nasılsınız");

            ////Dışarıdan oluşturuduğumuz yazıyı getbytes ile ascii kodları halinde dönüştürüyoruz ve byte dizisine atıyoruz. Yukarıda yazdığımız
            ////utf8Encoding(true) ile Türkçe karakterlere destek vermesi için yazdık.
            //fs.Write(metin, 0, metin.Length);
            ////byte şeklinde yazmamızın nedeni white metodunun btyte dizisi istemesi.
            //fs.Close(); // close satırı yazılmazsa yazma işlemi tamamlanmamış sayılacak ve işlem gerçekleşmeden program kapanacaktır.
            #endregion

            #region File

            //List<string> vs = new List<string>();
            //vs.Add("test");
            //vs.Add("test2");

            //File.AppendAllLines(@"C:\\Ios\\test.txt", vs, Encoding.UTF8);

            ////Satırları bir dosyaya ekler ve sonra dosyayı kapatır. Belirtilen dosya mevcut değil ise, bu yöntem ile dosya oluşturur, satırları 
            ////belirtilen dosyaya yazar ve sonra dosyayı kapatır.

            //var result = from line in File.ReadLines(@"C:\\Ios\\test.txt")
            //              where (line.StartsWith("test") || line.StartsWith("test2.txt"))
            //              select line;
            

            //File.WriteAllLines(@"C:\\Ios\\test.txt", result);

            //01.01.1700

            DateTime dt = new DateTime(1700, 1, 1);
            List<string> ks = new List<string>();

            for (int i = 0; i < 500; i++)
            {
               DateTime yenizaman = dt.AddDays(i);
               ks.Add(Convert.ToString(yenizaman));
            }
            

            File.WriteAllLines(@"C:\\Ios\\test.txt", ks, Encoding.UTF8);

            #endregion
        }
    }
}
