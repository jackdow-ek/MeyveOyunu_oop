
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_odev
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int zamanKosul=0;
        int indis;
        int gecici1;
        int gecici2;
        int gecici3;
        bool gecici4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void basla_Click(object sender, EventArgs e)
        {
            if(zamanKosul==0)
            {
                time_lbl.BackColor = Color.SkyBlue;
                time_lbl.Text = "60";//degerler sifirlanir
                label10.Text = "0";//degerler sifirlanir
                label12.Text = "0";//degerler sifirlanir
                label14.Text = "0";//degerler sifirlanir
                timer1.Enabled = true;//timer başlatılır
                zamanKosul = 1;//butonları kontrol ederken kullanılan değişken
                indis = rnd.Next(0, 6);//random indis üretilir
                pictureBox1.Image = ımageList1.Images[indis];//indise uygun fotoğraf pictureboxda gösterilir
                Meyve m1 = SinifCagir(indis);//Fotoğraftaki meyvenin sinifindan meyve üretilir ve değerleri struct yardımıyla döndürülür
                label3.Text = m1.ad + "";//meyve bilgileri yazdırılır
                label4.Text = "Ağirlik = " + m1.agirlik;//meyve bilgileri yazdırılır
                label5.Text = "Verim = " + m1.verim;//meyve bilgileri yazdırılır
                label6.Text = "Sivi/Pure miktar = " + m1.pureSivi;//meyve bilgileri yazdırılır
                label7.Text = "A vitamin(iu) = " + m1.A;//meyve bilgileri yazdırılır
                label8.Text = "C vitamin(mg) = " + m1.C;//meyve bilgileri yazdırılır
                gecici1 = m1.pureSivi;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici2 = m1.A;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici3 = m1.C;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici4 = m1.kontrol;//meyve durumu button kontrol işlemi için gecici değişkene atanır
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = Convert.ToString(Convert.ToInt32(time_lbl.Text) - (Convert.ToInt32(time_lbl.Text) - (Convert.ToInt32(time_lbl.Text) - 1)));
            if (time_lbl.Text == "0")//sayacın 0 olması durumu
            {
                time_lbl.BackColor = Color.Red;
                zamanKosul = 0;//tekrar başla butonunun işlem yapması için değişken değeri sıfırlanır
                timer1.Stop();
            }
        }

        struct Meyve//nesne döndüren fonksiyonların değerlerini tutacak olan struct
        {
            public string ad;
            public bool kontrol;
            public int agirlik;
            public int pureSivi;
            public int verim;
            public int A;
            public int C;
        }

        private Meyve SinifCagir(int index)//indexe göre classlardan meyve üretip döndüren fonksiyon
        {
            Meyve meyve = new Meyve();
            if (index == 0)//elma
            {
                Elma nesne = new Elma();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            else if (index == 1)//armut
            {
                Armut nesne = new Armut();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            else if (index == 2)//cilek
            {
                Cilek nesne = new Cilek();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            else if (index == 3)//portakal
            {
                Portakal nesne = new Portakal();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            else if (index == 4)//mandalina
            {
                Mandalina nesne = new Mandalina();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            else//greyfurt
            {
                Greyfurt nesne = new Greyfurt();
                nesne.MeyveYap(index);
                meyve.ad = nesne.AdMeyve;
                meyve.kontrol = nesne.MeyveKontrol;
                meyve.agirlik = nesne.GrAgirlik;
                meyve.pureSivi = nesne.GrPure;
                meyve.verim = nesne.Verim;
                meyve.A = nesne.VitaminA;
                meyve.C = nesne.VitaminC;
            }
            return meyve;//struct geri döndürülür
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gecici4==true && zamanKosul==1)//meyvenin kati olması durumu
            {
                label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + gecici1);//toplam degerler hesalanır ve yazdırılır
                label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + gecici2);//toplam degerler hesalanır ve yazdırılır
                label14.Text = Convert.ToString(Convert.ToInt32(label14.Text) + gecici3);//toplam degerler hesalanır ve yazdırılır
                indis = rnd.Next(0, 6);//yeni meyve fotoğrafi için indis üretilir
                pictureBox1.Image = ımageList1.Images[indis];
                Meyve m1 = SinifCagir(indis);//yeni fotoğraf için meyve üretilir
                label3.Text = m1.ad + "";//meyve bilgileri yazdırılır
                label4.Text = "Ağirlik = " + m1.agirlik;//meyve bilgileri yazdırılır
                label5.Text = "Verim = " + m1.verim;//meyve bilgileri yazdırılır
                label6.Text = "Sivi/Pure miktar = " + m1.pureSivi;//meyve bilgileri yazdırılır
                label7.Text = "A vitamin(iu) = " + m1.A;//meyve bilgileri yazdırılır
                label8.Text = "C vitamin(mg) = " + m1.C;//meyve bilgileri yazdırılır
                gecici1 = m1.pureSivi;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici2 = m1.A;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici3 = m1.C;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici4 = m1.kontrol;//meyve durumu button kontrol işlemi için gecici değişkene atanır
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gecici4 == false && zamanKosul == 1)//Meyvenin sivi olması durumu
            {
                label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + gecici1);//toplam degerler hesalanır ve yazdırılır
                label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + gecici2);//toplam degerler hesalanır ve yazdırılır
                label14.Text = Convert.ToString(Convert.ToInt32(label14.Text) + gecici3);//toplam degerler hesalanır ve yazdırılır
                indis = rnd.Next(0, 6);//yeni meyve fotoğrafi için indis üretilir
                pictureBox1.Image = ımageList1.Images[indis];
                Meyve m1 = SinifCagir(indis);//yeni fotoğraf için meyve üretilir
                label3.Text = m1.ad + "";//meyve bilgileri yazdırılır
                label4.Text = "Ağirlik = " + m1.agirlik;//meyve bilgileri yazdırılır
                label5.Text = "Verim = " + m1.verim;//meyve bilgileri yazdırılır
                label6.Text = "Sivi/Pure miktar = " + m1.pureSivi;//meyve bilgileri yazdırılır
                label7.Text = "A vitamin(iu) = " + m1.A;//meyve bilgileri yazdırılır
                label8.Text = "C vitamin(mg) = " + m1.C;//meyve bilgileri yazdırılır
                gecici1 = m1.pureSivi;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici2 = m1.A;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici3 = m1.C;//toplam hesaplama işlemi için gerekli değerleri geçici bir değişkene atanır
                gecici4 = m1.kontrol;//meyve durumu button kontrol işlemi için gecici değişkene atanır
            }
        }
    }
}
