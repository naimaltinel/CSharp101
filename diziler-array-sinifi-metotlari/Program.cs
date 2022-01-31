using System;

namespace diziler_array_sinifi_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("Sırasız Sayı Dizisi");
            foreach (var sayi in sayiDizisi);
            Console.WriteLine(sayi);
            
            Console.WriteLine("Sıralı Sayı Dizisi");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi);
            Console.WriteLine(sayi);

            //clear
            Console.WriteLine("Array Clear");
            Array.Clear(sayiDizisi,2,2); //2. index ten itibaren 2 tane elemanı sıfırlar

            Console.WriteLine("Sırasız Sayı Dizisi");
            foreach (var sayi in sayiDizisi);
            Console.WriteLine(sayi);

            //reverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi); //Diziyi ters çevirir

            Console.WriteLine("Sırasız Sayı Dizisi");
            foreach (var sayi in sayiDizisi);
            Console.WriteLine(sayi);

            //index of
            Console.WriteLine("Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //resize
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            
            foreach (var sayi in sayiDizisi);
            Console.WriteLine(sayi);




        

        }
    }
}
