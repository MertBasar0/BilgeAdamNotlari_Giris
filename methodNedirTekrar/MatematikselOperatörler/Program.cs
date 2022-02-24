using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselOperatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Toplamaİslemi
            int sayiBir = 102;
            int sayiIki = 25;
            int toplam = sayiBir + sayiIki;

            Console.WriteLine("Toplama işlemi sonucu" + toplam); //çıktı:sağına yazıldığı için otomatik metine çevirir toplamı


            Console.WriteLine("Toplama işlemi sonucu:" + sayiBir + sayiIki); //10225 metin birleştirme
            Console.WriteLine("Toplama işlemi sonucu" + (sayiBir + sayiIki)); //127
            #endregion
            Console.WriteLine("---------------------------------------------------");


            #region Çıkartma işlemi
                        
                int fark = sayiBir - sayiIki;
                Console.WriteLine("Çıkarma işlemi sonucu"+ fark);
                Console.WriteLine("Çıkarma işlemi sonucu" + (sayiBir - sayiIki));
            #endregion
            Console.WriteLine("---------------------------------------------------");

            #region Çarpma işlemi

            int carpim = sayiBir * sayiIki;
            Console.WriteLine("Çıkarma işlemi sonucu" + carpim);
            Console.WriteLine("Çıkarma işlemi sonucu" + (sayiBir * sayiIki));


            #endregion

            Console.WriteLine("---------------------------------------------------");

            #region Bölme işlemi

            int bölüm = sayiBir / sayiIki;
            Console.WriteLine("Çıkarma işlemi sonucu" + bölüm);
            Console.WriteLine("Çıkarma işlemi sonucu" + (sayiBir / sayiIki));


            #endregion

            #region mod alma

            int mod = sayiBir % sayiIki;
            Console.WriteLine("Çıkarma işlemi sonucu" + mod);
            Console.WriteLine("Çıkarma işlemi sonucu" + (sayiBir % sayiIki));

            #endregion

            #region sayiyi bir artırma
            int sayi = 15;
            sayi = sayi + 1;
            Console.WriteLine("sayının bir üst değerine atanmış hali" + sayi);
            sayi += 1;
            Console.WriteLine("sayının bir üst değerine atanmış hali"+sayi);
            sayi++;
            Console.WriteLine("sayının bir üst depere atanmış hali"+ sayi );

            #endregion

            Console.WriteLine("----------------------------");

            #region Sayiyi bir azaltma
            sayi = 15;
            Console.WriteLine("sayının ilk değeri" + sayi);
            sayi =














            Console.ReadLine();

        }
    }
}
