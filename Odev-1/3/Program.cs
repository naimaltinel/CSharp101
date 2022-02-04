using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aralarında boşluk bırakarak " + n + " tane kelime giriniz: ");
            string[] dizi = Console.ReadLine().Split(" ");
            for (int i=n-1; i>=0; i--)
            {
                Console.Write(dizi[i] + " ");
            }
            
        }
    }
}
