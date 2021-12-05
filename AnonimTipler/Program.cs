using System;

namespace AnonimTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous types => değeri atandığı zaman oluşan tiplerdir.. var keywordü ile tanımlanır. var tipindeki bütün değilenlerimizin tipleri anonimdir..
            var isim = "ekrem"; // string
            var cinsiyet = 'E'; // char
            var vize = 50.1f; // float


            //var durum; değer atanmadığı için hata verir...
            // Anonim tiplerde değer değişken oluşturulduğunda atanmalıdır..çünkü değişken o zaman oluşur. Eğer değer o an atanmayacaksa anonim tipi aşağıdaki tanımlanabilir

            var durum = default(bool); // değeri bool demiş olduk..
            durum = true;


            // Anonim tipler genelde çalışma zamanıda geçici tip oluşturmak için kullanılır...
            var ogr = new
            {
                Adi = "Ekrem",
                SoyAdi = "Yıldırım",
                Yas = 33,
                Cinsiyet = 'E'
            };

            Console.WriteLine($"{ogr.Adi}, {ogr.SoyAdi}, {ogr.Yas}, {ogr.Cinsiyet}");



            Console.ReadKey();
        }
    }
}
