using System;
using System.Collections.Generic;
using System.Linq; // linq kütüphanesi dosyaya dahil et...



namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(i);
            }
            #region old


            // sayilar dizisindei çift sayıları başka bir diziye(list) ekleyelim...
            // örn1
            List<int> ciftler = new List<int>();
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i] % 2 == 0) // % mod operatörü. bölümden kalanı verir..
                {
                    ciftler.Add(sayilar[i]);
                }
            }

            // 50'den küçük olan sayıları bir dizide, 50'den büyük olan sayıları başka bir dizide(list) tutalım

            List<int> kucukler = new List<int>();
            List<int> buyukler = new List<int>();

            foreach (var item in sayilar)
            {
                if (item > 50)
                {
                    buyukler.Add(item);
                }
                else
                {
                    kucukler.Add(item);
                }
            }
            #endregion
            // Öncelikle linq kullanıı için using ile System.Linq lütüphanesi ekleyiniz..
            // LINQ (LANGUAGE INTEGRATED QUERY) => Dile entegre sorgulama (query)
            // QUERY LANGUAGE => veritabanı programalarında sorgulama dili olarak kullanılır. SQL dili bilenen sorgulama dilidir...
            // linq query language'nin dile entegre edilmiş halidir...

            // linq ile koleksiyon (dizi,koleksyion,generic koleksyion vb) yapılarında sorgulama dili, döngü karar yapısı vb. ifadeler kullanmadan işlem yaparız..

            // örn1 linq
            // linq ile dizideki çift sayıları başka bir diziye ekleyelim..
            List<int> c = (from sayi in sayilar // sayilar listesindeki her bir değer a'ya atanır
                           where sayi % 2 == 0 // a ile karşılaştırma yapılr
                           select sayi).ToList(); // a seçilir

            List<int> b = (from i in sayilar
                           where i < 50
                           select i).ToList();

            List<int> k = (from j in sayilar
                           where j > 50
                           select j).ToList();

            // linq sorgularını dahada kısaltarak dizi üzerinden sorgulama işlemidir...
            // extensions metot

            // => lambda ifadesi
            List<int> c1 = sayilar.Where(sayi => sayi % 2 == 0).ToList(); // sayilara kriteter belirlenir.
            List<int> c2 = sayilar.Where(i => i < 50).ToList();
            List<int> c3 = sayilar.Where(j => j > 50).ToList();


            Console.ReadKey();
        }
    }
}
