using System;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
            //console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int temp;
            int n = 20;
            int[] numbers = new int[n];
            int[] bigNumbers = new int[3];
            int[] smallNumbers = new int[3];
            Console.WriteLine("20 tane sayı giriniz: ");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", (i + 1));
                int.TryParse(Console.ReadLine(), out temp);
                if (temp > 0)
                {
                    numbers[i] = temp;
                }
            }
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n-1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        var tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                    }
                }
            }
            int bigSum = 0;
            double bigAverage;
            int smallSum = 0;
            double smallAverage;
            for (int i=0; i<3; i++)
            {
                bigNumbers.Append(numbers[(n-1) - i]);
                smallNumbers.Append(numbers[i]);
                bigSum += numbers[(n - 1) - i];
                smallSum += numbers[i];
            }
            bigAverage = bigSum / 3.0;
            smallAverage = smallSum / 3.0;

            Console.WriteLine("En Büyük 3 Sayının Toplamı: {0} Ortalaması: {1}", bigSum.ToString(), Math.Round(bigAverage,2).ToString());
            Console.WriteLine("En Küçük 3 Sayının Toplamı: {0} Ortalaması: {1}", smallSum.ToString(), Math.Round(smallAverage,2).ToString());
        }
    }
}
