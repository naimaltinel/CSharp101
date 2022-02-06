﻿using System;

namespace hazir_metotlar_dattime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); //hangi gün
            Console.WriteLine(DateTime.Now.DayOfYear);// yılın kaçıncı günü
            Console.WriteLine(DateTime.Now.ToLongDateString()); //Saturday, April 24, 2022
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 4/27/2022
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(45));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);


            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

            Console.WriteLine(DateTime.Now.ToString("YY"));//21
            Console.WriteLine(DateTime.Now.ToString("YYYY"));//2021


            // *****MATH Kütüphanesi*****
            Console.WriteLine(Math.Abs(-25)); //Mutlak değer alır(25)
            Console.WriteLine(Math.Sin(90)); //90 sinüs değeri

            Console.WriteLine(Math.Ceiling(22.3)); // 23 döner (22'den büyük en küçük tam sayı)
            Console.WriteLine(Math.Round(22.3)); //22 döner(en yakın tam sayı)
            Console.WriteLine(Math.Floor(22.7)); //22 döner(aşağı yuvarlar)

            Console.WriteLine(Math.Min(2,6)); //min değeri verir
            Console.WriteLine(Math.Max(2,6)); //max değeri verir

            Console.WriteLine(Math.Pow(2,6)); //2^6
            Console.WriteLine(Math.Sqrt(9)); //karekök
            Console.WriteLine(Math.Log(9)); //9 e tabanında logaritmik karş.
            Console.WriteLine(Math.Exp(3)); //e^3
            Console.WriteLine(Math.Log10(10)); //10 sayısının log10 tabanında karş.



        }
    }
}