using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if(sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");
            }
            else if(sicaklik>=(int)HavaDurumu.sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım!");
            }
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal=20,
        sıcak=25,
        CokSıcak=30
    }
}
