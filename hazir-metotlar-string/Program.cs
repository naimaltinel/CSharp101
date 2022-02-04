using System;

namespace hair_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hoşgeldiniz!";
            string degisken2 = "CSharp";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(string.Concat(degisken, " Merhaba!"));

            //compare, compare to
            Console.WriteLine(degisken.CompareTo(degisken2)); //eşitse 0, 1. büyükse 1, ikinci büyükse -1
            Console.WriteLine(string.Compare(degisken,degisken2,true));//true büyük küçük harf duyarlı
            Console.WriteLine(string.Compare(degisken,degisken2,false));//false büyük küçük harf duyarsız

            //contains
            Console.WriteLine(degisken.Contains(degisken2));//1. değişkende 2. değişken varsa true döner
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // hoşgeldiniz ile bitiyorsa true
            Console.WriteLine(degisken.StartsWith("Merhaba")); //merhaba ile başlıyorsa true

            //indexOf
            Console.WriteLine(degisken.IndexOf("Merhaba")); //değişkenin indexini verir, yoksa -1

            //lastIndexOf
            Console.WriteLine(degisken.LastIndexOf("a")); //metindeki son a nın index'i

            //insert
             Console.WriteLine(degisken.Insert(0,"Merhaba")); //0. indexten başlayarak başına merhaba ekler

            //padleft, pedright
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //değişkeni 30'a tamamlamak için boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //değişkeni 30'a tamamlamak için yıldız ekler
            Console.WriteLine(degisken + degisken2.PadRight(30));
            Console.WriteLine(degisken + degisken2.PadRight(30,'-'));

            //remove
            Console.WriteLine(degisken.Remove(10)); //10. karakterden sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); //5. karakterden başlayı 3 karakter siler

            //replace
            Console.WriteLine(degisken.Replace("CSharp","c#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]); //boşluklardan bölüp dizi yaratıp 1. indexi getirir

            //substring
            Console.WriteLine(degisken.Substring(4));//4. indexten başlayıp sonuna kadar yazdırır
            Console.WriteLine(degisken.Substring(4,6));//4. indexten başlayıp 6'ya kadar yazdırır


        }
    }
}
