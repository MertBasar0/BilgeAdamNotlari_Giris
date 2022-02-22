using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swich___Case_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* 
            Switch - Case

        if - else mantığı ile çalışan bir kontrol mekanizmasıdır. Aralarındaki fark if - else yapısı büyüklüğü küçüklüğü gibi durumları kontrol ederken, 
        switch - case yalnızca eşitlik durumlarını kontrol edebilen yapımızdır. 
        
        Kendisine ait bir index mekanizması ile koşulları algılar,
        sıraya koyar ve otomatik olarak yüzlerce koşul olsa bile her birine bakmadan hangisine uyduğunu bulabilirsiniz. 
        Bu da performansı etkiler.. 
        Switch bloğu içerisinde yazdığınız veri tipinize ne ise case(durum) olarak belirttiğimiz tüm veriler de aynı veri tipi olmalıdır.
        break =>> Koşul sağlandı, artık karar yapısından kendini dışarı atmak için sisteme verilen mesajdır.
                      
         */
  
        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            switch (textBox1.Text)
            {
                case ":":
                        mesaj = "iki nokta üst üste";
                        break;
                case ".":
                        mesaj = "Nokta";
                        break ;
                case ",":
                        mesaj = "Virgül";
                        break;
                case "?":
                        mesaj = "Soru işareti";
                        break;
                    default:
                    mesaj = "böyle bir işaret yok..";
                    break;
            } 
                MessageBox.Show(mesaj); 
        }

        //DIşarıdan mevsim girilsin, aylar dönsün
        private void button2_Click(object sender, EventArgs e)
        {
            string mevsimler = "";

            switch(textBox2.Text)
            {
                case "ilkbahar":
                    mevsimler = "ocak,şubat,mart";
                    break;
                case "yaz":
                    mevsimler = "nisan,mayıs,haziran";
                    break;
                case "sonbahar":
                    mevsimler = "temmuz,ağustos,eylül";
                    break;
                case "kış":
                    mevsimler = "ekim,kasım,aralık";
                    break;

                default:
                    mevsimler = "böyle bir mevsim yok";
                    break;
            }
            //Default =>> Öngörülen bir durum harici değer karşılaştırarak, varsayılar olarak ne gibi bir işlem uygulanacağını gösterir.
            //Opsiyoneldir. Kullanılmasa da olur.
            MessageBox.Show(mevsimler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kisi = "";
            string metin = textBox3.Text.ToLower();
            switch (metin)
            {
                case "admin":
                case "başkan":
                case "moderatör":
                case "yönetici":
                    kisi = "Yönetim paneline yönlendiriliyorsunuz..";
                    break;
                case "Üye":
                    kisi = "ilgili sayfaya yönlendiriliyorsunuz..";
                    break;

                default:
                    kisi = "Giriş yetkiniz bulunmamaktadır..";  
                    break;
            }
            MessageBox.Show(kisi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kadi = textBox4.Text;
            string sifre = textBox5.Text;
            string mesaj = "";

            switch (kadi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            mesaj = "Hoşgeldiniz.."; 
                            break;
                        default:
                            mesaj ="Kullanıcı adı doğru şifreniz yanlış..";
                            break;
                    }
                    break;
                default:
                    mesaj = "Kullanıcı adınız hatalı, şifreye bakılmadı..";
                    break;
            }
            MessageBox.Show(mesaj);

        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //7.0 ile gelen yeni özellikle artık küçük büyük,küçükeşit, büyük eşit gibi tüm durumlarında kontrol edilebileceğini bilelim.
            //not: visual studio 2017 kullanabiliyor. önceki sürümlerde çalışmaz.

            int sayi= int .Parse(textBox6.Text);
            string mesaj = "";
            switch (sayi)
            {
                case int s when (s < 100):
                    mesaj = "Sayı 100'den küçüktür";
                    break;
                case int s when (s > 100):
                    mesaj = "Sayi 100'den büyüktür.";
                    break;
                default:
                    mesaj = "sayi 100'e eşittir.";
                    break;
            }
            MessageBox.Show(mesaj.ToString());
        }





        //Kullanıcı adı doğru şifre yanlış ise "Kullanıcı adınız doğru şifreniz hatalıdır." uyarısı
        //Kullanıcı adı yanlışsa "Kullanıcını adınız yanlış bu neden ile şifreye bakmadım bile" uyarısını vermenizi bekliyoruz...

        //KullanıcıAdi="bilgeadam";
        //Şifresi="1234";




    }
}
