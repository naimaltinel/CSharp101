using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0)
            {
                Console.WriteLine("Aralarında boşluk bırakarak " + n + " tane sayı giriniz: ");
                string[] array=Console.ReadLine().Split(" ");
                for(int i=0;i<n;i++)
                {
                    if(Convert.ToInt32(array[i])%2==0)
                    {
                        if(i<n-1)
                        Console.Write(array[i]+" ");
                        else
                        Console.Write(array[i]);
                    }               
                }
            }
            else
            Console.WriteLine("Pozitif bir sayı girmediniz!");
        }
    }
}
