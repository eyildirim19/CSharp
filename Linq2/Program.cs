using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci girilecek");
            int k = Convert.ToInt32(Console.ReadLine());

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            for (int i = 0; i < k; i++)
            {
                Ogrenci ogr = new Ogrenci();
                Console.WriteLine($"{i}. öğrencinin adı");
                ogr.AdiSoyAdi = Console.ReadLine();

                Console.WriteLine($"{i}. öğrencinin cinsiyeti");
                ogr.Cinsiyet = Convert.ToChar(Console.ReadLine());

                ogrencis.Add(ogr); // oluşturulan öğrenciyi ogr dizisine ekle....
            }

            // notları isteyelim...
            for (int i = 0; i < ogrencis.Count; i++)
            {
                Not n = new Not();

                Console.WriteLine($"{ogrencis[i].AdiSoyAdi} vizesi??");
                n.Vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{ogrencis[i].AdiSoyAdi} finali?");
                n.Final = Convert.ToSingle(Console.ReadLine());

                ogrencis[i].Notu = n; // sıradaki öğrencinin notuna n nesnesini set et...
            }

            Console.ReadKey();
        }
    }
}
