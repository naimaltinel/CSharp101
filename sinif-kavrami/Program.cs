using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {//Söz dizimi
         //class sınıfAdi
         //{
             //[Erişim Belirleyici] [Veri Tipi] Özellik adı
             //[Erişim Belirleyici] [Geri Dönüş Tipi] Metot adı([Parametre Listesi])
            //  {
                    //Metot Komutları
            //  }
         //}

         //Erişim Belirleyiciler
         // * Public (Her yerden erişilebilir)
         // * Private (tanımlandığı sınıftan erişilebilir)
         // * Internal (tanımlandığı proje içerisinde erişilebilir)
         // * Protected (tanımlandığı sınıf ve o sınıftan kalıtım alan sınıflarda)
        

        Calisan calisan1 = new Calisan();
        calisan1.Ad="Ayşe";
        calisan1.Soyad="Kara";
        calisan1.No=24232324;
        calisan1.Departman="İnsan Kaynakları";

        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan2.Ad="Deniz";
        calisan2.Soyad="Arda";
        calisan2.No=635363527;
        calisan2.Departman="Satın Alma";

        calisan2.CalisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departman:{0}",Departman);

        }

    }
}
