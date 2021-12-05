using System;
using System.Collections; // koleksiyonları kullanmak için kullanılan kütüphane

namespace Collectionsss
{
    class Program
    {
        static void Main(string[] args)
        {

            // Koleksiyonlar arrayler gibi kullanılan dizi varlıklarıdır. Dizilerden farkı uzun belirtmeden kullanılır. yani dinamik varlıklardır


            ArrayList liste = new ArrayList();
            //liste[0] = "aaa"; // uygulama bu satıtda hata verir çünkü add metodu ile alan açılıp eleman eklenebilir...
            liste.Add("aaaa"); // koleksiyona veri eklemek için kullanlır....
            liste[0] = "a"; // bu şekilde kullanılabilir. çünkü add metodu ile eleman eklenmeşir. eklenen eleman güncellenir...
            liste.Add("b");
            liste.Add("c");
            liste.Add("d");


            Console.WriteLine(liste.Count); // koleksiyonun eleman sayısını verir...


            // Neden koleksiyon kullanmamalıyız.? (Not : ge=neric koleksiyon değil)
            ArrayList sayilar = new ArrayList();
            sayilar.Add(1); // add metodu parametre olarak object tipinde değişken ister..

            // object => c# dilindi bütün her şeyin atasıdır...bu yüzden bütün ön tanımlı veya bizim tiplerimizdeki bütün veriler object türünde saklanabilir... object türüne bir değişkene değer atama işlemine boxing işlemi denir... çünkü object sadece değişkenin refernasını tutar... 

            // boxing
            int sayi1 = 4, sayi2 = 5;
            object o = "bt akademi";
            object i = 555;
            object c = 'A';
            object b = true;


            object s1 = sayi1;
            object s2 = sayi2;

            // objecten diğer türlere dönüşüm işlemine unboxing denir
            // unboxing
            int s = (int)s1; // s1'i inte çevir
            string str = (string)o; // o'yı stringe çevir

            // boxing ve unboxing işlemleri performans sorunu yaratan işlemlerdir. zorunlu olmadıkça kullanılmaz..

            // koleksiyonlar veri saklarken object türünde saklar. boxing ve unboxing işlemine tabi tutulurlar...bu yüzden performans problemi olan varlıklardır. Ayrıca object türünden değer sakladığı için tip güvenliği yoktur. tip güvenlipi olmadığı için tip güvenliği olan generic koleksiyonları kullanırz.
            sayilar.Add(2);
            sayilar.Add("iki");

            // not:  koleksiyonlardaki tip uyuşmazlığı hataları runtimeda(çalışma zamanı) oluşurlar...

            foreach (var item in sayilar)
            {
                if (item is int)
                {
                    int sayi = (int)item; // 
                }
                else if (item is string)
                {
                    string hsayi = (string)item;
                }
            }

            // not:  arraylist maceramız başlamadan bitmiştir. Array kullanımıda bitmiştir. bundna sonraki süreçlerde generic koleksiyonlardan List olanı kullanacağız...

            Console.ReadKey();
        }
    }
}