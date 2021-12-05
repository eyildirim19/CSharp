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



            // not: select ifadesiden seçilen obje tipinde değer dönüşür

            // linq sorgularına başlayalım....
            // Cinsiyeti erken olan öğrenciler...
            List<Ogrenci> baylar = (from o in ogrencis
                                    where o.Cinsiyet == 'e'
                                    select o).ToList(); // öğrenciyi seç

            // cinsiyeti k olan ve ortalaması 50 den byük olan
            List<Ogrenci> bayanlar = (from b in ogrencis
                                      where b.Cinsiyet == 'k' && b.Notu.Ortalama > 50
                                      select b).ToList();

            //notu 50'den büyük olanların adsoyadlrı
            List<string> isimler = (from j in ogrencis
                                    where j.Notu.Ortalama > 50
                                    select j.AdiSoyAdi).ToList(); // geriye string dön...

            //notu 50'den küçük olanların cinsiyet
            List<char> cinsyeyler = (from c in ogrencis
                                     where c.Notu.Ortalama < 50
                                     select c.Cinsiyet).ToList();

            // notu 50'den büyük olanları adsoyoad ve cinsiyetleri
            // Not : select ifadesinde new komutu kullanılırsa sorgudan dönen sonuç anonimdir...
            var result = (from c in ogrencis
                          where c.Notu.Ortalama > 50
                          select new
                          {
                              c.AdiSoyAdi,
                              c.Cinsiyet
                          }).ToList();

            foreach (var item in result)
                Console.WriteLine($"{item.AdiSoyAdi} {item.Cinsiyet}");

            // sınıf ortlamasını bulalım...
            float ortalam = ogrencis.Sum(c => c.Notu.Ortalama) / ogrencis.Count;
            float ortalama = ogrencis.Average(c => c.Notu.Ortalama);



            Console.ReadKey();
        }
    }
}
