using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
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
        
        Console.WriteLine("******Çalışan 1******");
        Calisan calisan1 = new Calisan("Ayşe","Kara",24232324,"İnsan Kaynakları");
        calisan1.CalisanBilgileri();

        Console.WriteLine("******Çalışan 2******");
        Calisan calisan2 = new Calisan();
        calisan2.Ad="Deniz";
        calisan2.Soyad="Arda";
        calisan2.No=635363527;
        calisan2.Departman="Satın Alma";
        calisan2.CalisanBilgileri();

        Console.WriteLine("******Çalışan 3******");
        Calisan calisan3 = new Calisan("Naim","Altınel");
        calisan3.CalisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.Departman=departman;
            this.No=no;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }  
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departman:{0}",Departman);

        }
        
    }
}
