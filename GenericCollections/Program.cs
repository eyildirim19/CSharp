using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("furkan");
            kisiler.Add("ekrem");
            kisiler.Add("evren");
            //kisiler.Add(3); tip güvenliğinden dolayı kisiler koleksiyonuna  başka değer atanamaz...

            List<char> karakterler = new List<char>();
            for (int i = 65; i < 91; i++)
                karakterler.Add(Convert.ToChar(i)); // sayiyi char'a çevir ve listeye ekle....


            // işiimiz bitti..
            foreach (var item in karakterler)
            {
                Console.Write(item);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < karakterler.Count; i++)
            {
                Console.Write(karakterler[i]);
            }

            // liste oluştururken bazen index değerlerini kendimiz belirlemek isteyebiliriz.Bu durumda dictionary kullanılır.instance alırken generic oludğu için iki adet type ister. bunlardan biri indexin tipi, diperi valuenın tipidir
            Dictionary<string, string> kisiler2 = new Dictionary<string, string>();
            kisiler2.Add("a", "Furkan");
            kisiler2.Add("b", "Ekrem");

            string kim = kisiler2["b"]; // b'ninci indexteki değeri kim değişkenine ata...

            Dictionary<int, string> denem = new Dictionary<int, string>();
            denem.Add(1, "A");
            denem.Add(2, "B");


            string str = denem[1]; // 1'inci indextgeki değeri str değişkenine ata...


            foreach (var item in kisiler2)
            {
                Console.Write(item.Value); // kisiler2'deki satır value'sıı ekrana yazdır...
            }


            Console.ReadKey();
        }
    }
}
