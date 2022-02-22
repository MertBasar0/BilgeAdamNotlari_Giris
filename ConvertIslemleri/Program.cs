using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fonsiyonlar parantezle kullanılırlar..()
            //Bir veri tipindeki değişkeni, diğer veri tipine çevirmek için ihtiyacımız olan yardımcı bir sınıf vardır.
            //Bu sınıf convert sınıfı
            //BUrada ekstra bir durumda daha söz konusu olabilir. Dış dünyadan gösterilecek olan ne varsa, bu değerler kesinlikle metinsel(string) veri tipi olacaktır. Dolayısıyla .net bize tipler arası geçişte kolaylık sağlar.


            int sayi = 23;
            sayi++;

            Console.WriteLine(sayi.ToString()); // Değer stringe çevrildiğinde matematiksel özelliklerini kaybeder.
            string cevrilecekDegerr = Convert.ToString(sayi);
            //cevrilecekDeger++;
            Console.WriteLine(sayi);


            string cevrilecekDeger = "123";
            int cevrilmisDeger = Convert.ToInt32(cevrilecekDeger);
            byte cevrilendegeriki = Convert.ToByte(cevrilecekDeger);
            short cevrilmisUc = Convert.ToInt16(cevrilecekDeger);
            long cevrilmisdegerDort = Convert.ToInt64(cevrilecekDeger);
            float cevrilmisdegerBes = Convert.ToSingle(cevrilecekDeger);


            bool sonuc = true;
            Console.WriteLine(sonuc.ToString());


            Console.ReadLine();  
        }
    }
}
