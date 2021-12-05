using System;
using System.Collections.Generic;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable tipler...

            // referans tipler (reference type) => referns tutan tipler (class ve diziler)
            Ogrenci ogr;
            string str;
            List<string> kisiler;
            List<Ogrenci> ogrenciler;
            Ogrenci[] ogrenciler1;
            int[] sayilar;


            // değer tipler (value type)=>değer tutan tipler => (struct). Değer tiplerin defautl değerleri vardır.. bazı durumlarda değer tiplerinde null olmasını isteyebiliriz..
            int sayi;
            char c;
            decimal d;
            bool b;

            // değer tiplerin neden null olmaısnı isteriz. çünkü bir ürün stoku olmaya bilir, öğrencinin notu eklenmemiş olabilir..
            // değer tiplerin null olması için değilen tanımlarken tipin nullable generici ile belirtilmesi gerekir..

            //int stok = null; => int değer tip olduğu null değeri set edilemez....

            Nullable<int> stok = null; // değilen tipi nullable yapıldığı için artık null değerini kabul eder...
            Nullable<char> k = null;

            // Nullable tanımlamanın iki yolu vardır. bunlar nullable ifadesi ve ? ifadesidir..
            int? vize = null;
            decimal? money = null;
            char? kc = null;

            // Nullable<Ogrenci> o = null; // referans tipler nullable işaretlemezler. çünkü zaten nullable'dırlar

            int stok1 = stok.Value; // nullable tipinin varsayılan değeri alınabilir...

            if (stok.HasValue) // nullable tipin değeri var ise
            {
                int stok2 = (int)stok;
                // yada
                //int stok3 = stok.Value;
            }


            Console.ReadKey();
        }
    }
}
