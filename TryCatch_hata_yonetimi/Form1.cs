using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch_hata_yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);

            int toplam = deger - deger2;
            MessageBox.Show(toplam.ToString());

        }

        private void btn_Hata_yonetimi_Click(object sender, EventArgs e)
        {
            try
            {
                //Bu alana hata riski olan kodlar girilir.
                int gelenDeger = Convert.ToInt32(textBox4.Text);
                MessageBox.Show("Doğru Format"); 
            }
            catch (Exception)
            {
                //try boluğunda yazmış olduğunuz kodlarda bir hata çıkar ise Catch bloğu devreye girer.
                MessageBox.Show("Lütfen Doğru değer giriniz..");
            }
        }

        private void btn_DetaylıHata_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = int.Parse(textBox5.Text);
                MessageBox.Show("Tebrikler ! DOĞRU format girdiniz..");
            }
            catch (Exception hata)
            {

                //Catch ifadesini yanındaki excaption kelime anlamı =>> istisna..
                //Uygulamanın karlılığını bozan istisnai durumla ilgili sizlere detayları teslim eder..
                //Hata'nın sistem tarafından atanan mesajını size teslim eder.
                MessageBox.Show(hata.Message);
            }
        }



        private void btn_HataTipleri_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(textBox7.Text);

            }
            catch(DivideByZeroException hata)// Sıfıra bölme hatası yakalarsa.
            {
                MessageBox.Show("DivideByzeroException: " + hata.Message);
            }
            catch(OverflowException ex) //veritipinin boyutunu aşması durumunda alınan hata.
            {
                MessageBox.Show("OverFlowExcaption: "+ex.Message);
            }
            catch(FormatException dex)//Format hata tipi
            {
                MessageBox.Show("Format Excaption: " + dex.Message);
            }
            catch(Exception)// Excaption sınıfı tanımlı olan hatalar haricinde bir hata ile karşılaşırsa bu alandaki hata bloğu çalışacaktır.
            {
                MessageBox.Show("hata var");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }









        // İstisna tipler
        // Çalışma zamanı hataları (runtime exception) =>
        // Çoğunlukla kullanıcı kaynaklı hatalardır.
        //verilerin yanlış girilmesi ya da eksik girilmesi ya da boş gönderilmesi çözüm yolu try-catch ile kullanıcı kaynaklı bu hataları ele alabilirsiniz.

        // Derleme zamanı hataları (compile excaption) =>

        // Tamamen yazılımcı kaynaklı hatalardır. Yazılım hataları meydana geldiğinde devreye girer. En kolay çözülen hata tipidir. Visual studio sizi uyarır.(Aşağıdaki error list penceresi ile )
        // ilgili hatanın üzerine gelip çift tıklarsanız sizi hataya götürür. Anında düzeltebilirsiniz.


        //Mantıksal Hatalar =>>
        //Tamamen ayzılımcı kaynaklı hatalardır. Uygulamanın algoritmasında meydana gelir. Örneğin; bölme yapılacak yerde işlemi unuttunuz bu sebepten dolayı işlem sonucu hataları dönmektedir. Bu hatalar çözülmesi en zor hatalardır. Anlık olarak derleme aşaması edilmelidir. Ve değer gözlenmelidir.
        //Bu konuda visual studio harika toolbar 


        //BreakPoint kullanımı satır numaralarının sağ tarafında kalan gri alana tıklandığında konulabilir.
        //Yazılan kodu koyulan breakpoint e kadar çalıştırır.
        //Derleme aşamasına adım adım dahil olmak için kullandığımız yardımcı tooldur.
        // Bu sayede breakpoint e kadar kodun neler yaptığı izlenebilir. Derleyici  işaretlenen satıra geldiğinde sizi oraya dahil edecektir ve adımları birlikte yönetebileceksiniz.
        //F11 ile ilerleyebilirsiniz. Değişkenlerin o anlık değeri üzerine gelip beklediğinizde üzerindeki o anlık değeri görebilirsiniz. işlemin bittiğini düşünüyorsanız F5 e basarak kendiliğinden BREAKPOINT den çıkabilirsiniz. Çıktıktan sonra işlem kendiliğinden devam edecektir.
        //Sol blokta çıkan sarı ok, derlenen satırın işaretleyicisidir. Mause yardımı ile geri oynatılabilir. Yani adımları atlayabilir ya da tekrarlayabilirsiniz.

        //Watch 
        //Yanlızca run time 'da çalışma zamanında kullanılır. Dolayısı ile penceremiz sadece çalışma zamanında görünür.
        //Eğer sizlerde kapalı ise. Uygulamayı çalıştırdığınızda "ctrl+alt+w" ardından 1'e basarsanız Watch penceresini getirebilirsiniz.


        //Runtime 'da elinizde olan değerleri (kontrol değerler, değilen değerler) açılan pencerede iki alan çıkar karşınıza name ve value alanları. Takip edilen değişkenin adını name bölümüne yazarsanız. Program ilerledikçe eklenen field program içerisindeki değer değişiklikleri watch penceresinden takip edilebilir. Bu arada name alanında ctrl+space yaparsanız intelense kısmına aradığınız değişkenleri hızlıca bulabilirsiniz.
        // Noktalarınız, virgülleriniz // tüm c# kuralları bu alan için geçerlidir.

























    }
}
