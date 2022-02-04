using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // //verilere erişim
            // Console.WriteLine(liste[0]);

            // foreach (var item in liste)
            //     Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***** Add Range *****");
            //string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1,18,87,9,12};

            //liste.AddRange(renkler);
            liste.AddRange(sayılar);
            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();

            //Binary Search (Sıralamadan sonra çalışır)
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            liste.Reverse();

            //clear
            liste.Clear();


        








        }
            

    }
}
