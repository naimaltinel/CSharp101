using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: 
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde 
            //saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            
            Console.WriteLine("Lütfen Bir Cümle Giriniz: ");
            string sentence = Console.ReadLine();
            int count = sentence.Length;
            char[] vowels = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            char[] sentenceArray = sentence.ToCharArray();
            ArrayList sentenceVowels = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if (sentenceArray[i] == vowels[j])
                    {
                        sentenceVowels.Add(vowels[j]);
                        break;
                    }
                }
            }
            sentenceVowels.Sort();
            foreach(char c in sentenceVowels)
            {
                Console.WriteLine(c);
            }
        }
    }
}
