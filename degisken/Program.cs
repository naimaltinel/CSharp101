using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5; //1 byte, Z, (0 - 255)
            sbyte c = 5; //1 byte, Z, (-128 - 127)

            short s = 5; //2 byte, Z, (-32768 - 32768)
            ushort us =5; //2 byte, Z, (0 - 65365)

            Int16 i16 = 2; //2 byte
            int i = 4; //4 byte
            Int32 i32 = 4; //4 byte
            Int64 i64 = 8; //8 byte

            uint ui = 2; //4 byte
            long l = 8; //8 byte
            ulong ul = 8; //8 byte

            //reel sayılar
            float f = 4; //4 byte
            double d = 8; //8 byte
            decimal de = 16; //16 byte

            char ch = '2'; //2 byte
            string str = "sonsuz"; //sınırsız yer kaplar

            bool b1=true;
            bool b2=false;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3= 4;
            object o4= 4.3;

            //string ifadeler
            string str1=string.Empty;
            str1="Naim Altınel";
            string ad="Naim";
            string soyad = "Altınel";
            string tamIsim = ad+ " " +soyad;

            //integer tanımlama şekilleri
            int integer1=5;
            int integer2=3;
            int integer3=integer1*integer2;

            //boolean
            bool bool1=10<2;

            // değişken dönüşümleri
            string str20="20";
            int int20=20;
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger); //çıktısı 2020

            int int21=int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktısı 40

            int int22 = int20 + int.Parse(str20); //çıktısı 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
