using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Söz Dizimi
            // class SınıfAdı {
            //     [Erişim Belirteci] [Veri Tipi] ÖzellikAdi;
            //     [Erişim Belirteci] [Dönüş Tipi] MetotAdi ([Parametre Listesi]){
            //          //Metot komutları        
            //      }
            //      
            // }



            //Erişim belirleyiciler
            //public
            //private
            //internal
            //protected

            Calisan calisan = new Calisan();
            calisan.Ad = "Hasan";
            calisan.Soyad = "KAHRAMAN";
            calisan.No = 12345678;
            calisan.Departman = "BT";

            calisan.CalisanBilgileri();

            Console.WriteLine("******************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Kenan";
            calisan2.Soyad = "KARAMAN";
            calisan2.No = 67812345;
            calisan2.Departman = "İK";

            calisan2.CalisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }

    }
}
