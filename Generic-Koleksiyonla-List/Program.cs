using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonla_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T--> Object türündedir nesne alabilir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);
            
            List<string> RenkListesi = new List<string>();
            RenkListesi.Add("Kırmızı");
            RenkListesi.Add("Mavi");
            RenkListesi.Add("Turuncu");
            RenkListesi.Add("Sarı");
            RenkListesi.Add("Yeşil");

            //count
            Console.WriteLine(RenkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve list.foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in RenkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            RenkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            RenkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);//indexe göre çıkarma
            RenkListesi.RemoveAt(1);

            //Liste içinde arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu");
            }

            //eleman ile index e erişim
            RenkListesi.BinarySearch("sarı");//index ini getirir

            //Diziyi List e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanlarList = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanlarList.Clear();


            //List içinde nesne tutmak
            kullanıcılar kullanıcı1 = new kullanıcılar();
            



        }
    }

    public class kullanıcılar
    {
        string isim;

        string soyisim;

        int yas; 

    }
}
