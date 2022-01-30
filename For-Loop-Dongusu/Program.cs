using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları yazdır
            // Console.WriteLine("Lütfen bir sayı giriniz");
            // int sayac = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= sayac; i++)
            // {
            //     if(i%2 == 1)
            //         Console.WriteLine(i);
            // }
            // // 1 ile 1000 arasındaki tek ve çift sayıların ayrı ayrı toplamlarını yazdırma
            // int tekToplam = 0, ciftToplam = 0, a=1000;
            // for (int i = 1; i <= a; i++)
            // {
            //     if (i % 2 != 1)
            //         tekToplam += i;//tekToplam=tektoplam+i
            //     else
            //         ciftToplam += i; 
            // }
            // Console.WriteLine("Tek Toplam= " + tekToplam);
            // Console.WriteLine("Çift Toplam= " + ciftToplam);

            // break continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break; //4'e kadar olanları yazdırır, 4'e gelince durur.
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                continue; //sadece 4'ü atlayıp diğerlerini yazdırır.
                Console.WriteLine(i);
            }


        }
    }
}
