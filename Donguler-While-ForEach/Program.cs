using System;

namespace Donguler_While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // //while
            // //1'den başlayıp konsoldan girilen sayıya kadar (sayı dahil) ort hesaplayıp konsola yazdıran program.
            // Console.WriteLine("Lütfen bir sayı giriniz: ");
            // int sayi1 = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi1)
            // {
            //     toplam += sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi1);

            // //a'dan z'ye kadar tüm harfleri console 'a yazdıralım.
            // char character = 'a';
            // while (character < 'z')
            // {
            //     Console.Write(character);
            //     character++;
            // }

            Console.WriteLine("*****Foreach*****");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
