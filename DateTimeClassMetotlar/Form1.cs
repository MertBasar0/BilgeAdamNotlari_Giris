using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeClassMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Güncel zaman bilgisini label a yazdır.
            label1.Text = DateTime.Now.ToString();
            //Günün tarihini alma
            label1.Text = DateTime.Now.ToLongDateString();
            label1.Text = DateTime.Now.ToShortDateString();

            //Şu anki zamanı alma

            label1.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToShortTimeString();

            // Tarih formatlama


            label1.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            //Artık yıl

            bool sonuc = DateTime.IsLeapYear(2012);
            MessageBox.Show(sonuc == true ? "şubat 29 çeker" : "şubat 28 çeker");

            //haftanın günü

            label1.Text= DateTime.Now.DayOfWeek.ToString();

            //yılın kaçıncı günü

            label1.Text= DateTime.Now.DayOfYear.ToString(); 

        }

        private void btn_timeSpan_Click(object sender, EventArgs e)
        {
            // iki zaman arasındaki fark

            DateTime yenizaman = new DateTime(1994,09,04,00,00,00);
            DateTime suan;
            suan = DateTime.Now;
            TimeSpan fark = suan - yenizaman ;

            int toplagun = fark.Days;

            label1.Text = toplagun.ToString();


            









        }
    }
}
