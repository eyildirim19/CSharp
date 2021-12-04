using System;
using System.Collections.Generic;

namespace GenericYapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic koleksyionlar => arrayleri dinamik kullanmak (uzunluk belirtmeden) kullanılır.. Burada kullanacağımız en önemli sınıf List generic sınıfıdır. Gelişmiş dizi yapısı gibi düşünebilirsiniz.. Bu sınıfı kullanmak için dosyasına SYstem.Collections.Generic namespacesini eklemeniz gerekmektedir...
            int[] sayilar = new int[5];
            // Bundan sonra array yerine list yapılarını kullanacağız..

            // listlerde eleman eklemek için add metodu kullanılır. Add metodu listelere sıralı eleman eklemek için kullanılır...
            List<int> sayilar2 = new List<int>(); // int tipinde list oluşturduk. <int> ifadesi ile sayilar2 listine sadece int eleman eklenebileceğini belirttik
            sayilar2.Add(4);
            sayilar2.Add(120);

            List<string> kisiler = new List<string>();
            kisiler.Add("Furkan");
            kisiler.Add("Evren");
            kisiler.Add("Ekrem");

            List<char> karakterler = new List<char>();
            karakterler.Add('A');
            karakterler.Add('B');

            foreach (var item in sayilar2)
                Console.WriteLine(item);


            foreach (var item in kisiler)
                Console.WriteLine(item);

            foreach (var item in karakterler)
                Console.WriteLine(item);

            Console.WriteLine("Hello World!");
        }
    }
}
