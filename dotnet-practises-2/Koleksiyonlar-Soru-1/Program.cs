using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: 
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            //(ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            Islemler islem = new Islemler();
            ArrayList liste = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList not_asal = new ArrayList();

            Console.WriteLine("Lütfen 20 tane sayı giriniz: ");
            try
            {
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine("{0}.sayıyı giriniz: ", i);
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    liste.Add(n);
                }
            }
            catch
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            }
            foreach (int item in liste)
            {
                if (item == 1)
                {
                    not_asal.Add(item);
                }
                else if (item == 2)
                {
                    asal.Add(item);
                }
                else
                {
                    int asalsayi = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            asalsayi++;

                        }
                    }
                    if (asalsayi == 0)
                    {
                        asal.Add(item);
                    }
                    else
                    {
                        not_asal.Add(item);
                    }
                }
            }
            Console.WriteLine("Toplam: " + asal.Count +" tane asal sayı vardır.");
            Console.WriteLine("Büyükten küçüğe asal sayılar: ");
            islem.Siralama(asal);
            islem.Ortalama(asal);
            Console.WriteLine("Toplam: " + not_asal.Count +" tane asal olmayan sayı vardır.");
            Console.WriteLine("Büyükten küçüğe asal olmayan sayılar: ");
            islem.Siralama(not_asal);
            islem.Ortalama(not_asal);
        }

        public class Islemler
        {
            public ArrayList Siralama(ArrayList arr)
            {
                arr.Sort();
                arr.Reverse();
                foreach (var item in arr)
                {
                    Console.WriteLine(item + " ");
                }
                return arr;
            }
            public ArrayList Ortalama(ArrayList arr)
            {
                int toplam = 0;
                foreach (int item in arr)
                {
                    toplam += item;
                }
                decimal ort = toplam/arr.Count;
                Console.WriteLine("Sayıların ortalaması: " + ort);
                  return arr;
            }
        }
    }
}
