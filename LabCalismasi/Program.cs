using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Dışarıdan alinan iki sayinin toplamıyla farkının birbirine bölünmesinden kalanın sonucu kaçtır ??

            //int sayi1;
            //int sayi2;
            //int sonucToplam;
            //int sonucFark;
            //int sonucKalan;
            //int sonuc;


            //Console.WriteLine("Lütfen birinci sayiyi giriniz..");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayiyi giriniz..");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //sonucFark = sayi1 - sayi2;
            //sonucToplam = sayi1 + sayi2;
            //sonucKalan = sonucToplam % sonucFark;

            //Console.WriteLine("İşlem sonucu: " + sonucKalan);


            //Console.ReadKey();
            #endregion



            #region
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi kaçtır ?


            //int sayi;
            //int sonuc58;

            //Console.WriteLine("Lütfen bir sayı giriniz..");
            //sayi= Convert.ToInt32(Console.ReadLine());
            //sayi= (sayi - 10 + 20) % 2;
            //sonuc58 = sayi * sayi;
            //Console.WriteLine("İşlemin sonucu: "+ sonuc58);

            //Console.ReadLine();

            #endregion


            #region soru3


            //dışarıdan girilen iki sayının karelerinin toplamı ile karelerinin farkı toplamı kaçtır?

            //int sayi1;
            //int sayi2;
            //double sayi1karesi;
            //double sayi2karesi;
            //double toplam;
            //double fark;
            //double sonuc;

            //Console.WriteLine("Lütfen birinci sayiyi giriniz..");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayiyi giriniz..");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //sayi1karesi= Math.Pow(sayi1, 2);
            //sayi2karesi= Math.Pow(sayi2, 2);
            //fark= sayi1karesi - sayi2karesi;
            //toplam= sayi1karesi + sayi2karesi;
            //sonuc = toplam + fark;

            //Console.WriteLine("İşlem sonucu: " + sonuc);

            //Console.ReadKey();
            #endregion


            #region soru4
            //Bİr üniversite için not hesaplaması sistemi yazılması isteniyor.
            // Bu program içerisinde öğrencinin vize ve final notu alınıp not ortalaması çıkarması beklenir.
            //Bu programa göre vize notu %30'u final notunun %70'ini alıp ortalamayı ekrana bastırınız.
            //Dikkat: Notlar ondalıklı olabilir.

            //float vize;
            //float final;
            //float sonuc;

            //Console.WriteLine("Lütfen vize notunuzu giriniz..");
            //vize= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen final notunu giriniz..");
            //final = Convert.ToInt32(Console.ReadLine());

            //vize = (vize / 100) * 30;
            //final = (final / 100) * 70;

            //sonuc = vize + final;

            //Console.WriteLine("Dönem notunuz.." +sonuc);

            //if (sonuc >= 70)

            //    Console.WriteLine("Geçtiniz..");

            //else
            //    Console.WriteLine("Kaldınız..");

            //Console.ReadKey();  


            #endregion

            #region soru5

            //DIşarıdan kullanıcı adını ve soyadını ayrı ayrı alınız ve adı.soyadi@bilgeadam.com şeklinde bir mail adresi oluşturup kullanıcıya gösteriniz.

            //string adi, soyadi;

            //Console.WriteLine("İsminizi giriniz..");
            //adi= Console.ReadLine();
            //Console.WriteLine("Soyisminizi giriniz..");
            //soyadi= Console.ReadLine();

            //Console.WriteLine(adi+"."+soyadi+"@bilgeadam.com");
            //Console.ReadKey();
            #endregion


            #region üçgenin açısı

            //Dışarıdan aldığımız iki açısı verilen üçgenin üçüncü dış açısını hesaplayan program.

            int birinciaci, ikinciaci,ucuncuaci;

            Console.WriteLine("Üçgenin birinci açısını giriniz..");
            birinciaci= Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Üçgenin ikinci açısınız giriniz..");
            ikinciaci = Convert.ToInt32( Console.ReadLine());

            ucuncuaci = 360- (birinciaci + ikinciaci);
            Console.WriteLine("Üçüncü açı: " + ucuncuaci);

            Console.ReadKey();  



            #endregion


        }
    }
}
