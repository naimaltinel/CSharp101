using System;

namespace static_sinif_uyeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Zikriye","Ürkmez","IK");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu:{0}", Islemler.topla(100,200));
            Console.WriteLine("Toplama işlemi sonucu:{0}", Islemler.cikar(400,50));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string ısim, string soyIsim, string departman)
        {
            this.Isim = ısim;
            this.SoyIsim=soyIsim;
            this.Departman=departman;
            calisanSayisi++;
        }



    }
    static class Islemler
    {
        public static long topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long cikar (int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
