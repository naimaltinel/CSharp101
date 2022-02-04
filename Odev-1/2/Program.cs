using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            Console.WriteLine("Aralarında boşluk bırakarak 2 tane sayı giriniz: ");
            string[] dizi = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(dizi[0]);
            int m = Convert.ToInt32(dizi[1]);
            Console.WriteLine("Aralarında boşluk bırakarak " + n + " tane pozitif sayı giriniz: ");
            string[] ndizi = Console.ReadLine().Split(" ");
            Console.WriteLine(m + " sayısına eşit yada tam bölünenler: ");
            for (int i = 0;i<n-1;i++)
            {
                if(Convert.ToInt32(ndizi[i])%m==0 || Convert.ToInt32(ndizi[i])==m)
                Console.Write(ndizi[i] + " ");
            }
        }
    }
}
