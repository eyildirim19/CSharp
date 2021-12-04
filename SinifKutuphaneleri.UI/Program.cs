using System;
using SinifKutuphaneleri.Classes; // projenin namespace'sini dosyamıza ekledik. Proıje içerisinde erişebileceğimiz classlar bu dosyadan erişilebilir...
namespace SinifKutuphaneleri.UI
{
    class Program
    {

        // Main metodu bir console uygulamasını yürüyen metottur.
        static void Main(string[] args)
        {
            //1) bir sınıf kütüphanesini projenizde kullanabilmek için o sınıf kütüphanei proye dahil etmeniz gerekir. Sınıf kütüphensi projenize eklemek için dependencies sekmesne sağ tık yapıp add project reference penceresinden eklemek istediğiniz projeyi seçtiğinizde projeniz eklenecektir.....

            // 2) Kullanılacak sınıfın namespace'isini using bölümüne eklemeniz gerekir.
            Nots n = new Nots();
            n.Vize = 50;
            n.Final = 50;

            Adres adr = new Adres();
            adr.AdresAdi = "Ev Adres";
            adr.AcikAdres = "Bla bla";
            adr.Il = "İstanbul";
            adr.Ilce = "Üsküdar";


            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Ekrem";
            ogr.SoyAdi = "YILDIRIM";
            ogr.Notu = n;
            ogr.Adresi = adr;

            // Not propertsi üzerinden vizesini gösteriyoruz..
            Console.WriteLine($"Bu öğrencinin vizesi {ogr.Notu.Vize}");
            Console.WriteLine($"Bu öğrencinin açık adresi {ogr.Adresi.AcikAdres}");
            // OgrenciOld ol = new Classes.OgrenciOld(); erişim seviyesi internal olduğu içn bu projeden erişilemez...

            Console.ReadKey();
        }
    }
}
