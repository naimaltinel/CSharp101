using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle yazınız: ");
            string[] kelime = Console.ReadLine().Split(" ");
            int harfSayac = 0;
            for(int i=0;i<kelime.Length;i++)
            {
                char[] temp = kelime[i].ToCharArray();
                harfSayac+=temp.Length;
            }
            Console.WriteLine("Cümledeki toplam kelime sayısı: " + kelime.Length + ", toplam harf sayısı: " + harfSayac + ".");
                
        }
    }
}
