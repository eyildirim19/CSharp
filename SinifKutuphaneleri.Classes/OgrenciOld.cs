using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifKutuphaneleri.Classes
{
    // doğru tanımlamayı Ogrenci sınıfı ile yaptık..Nots ve Adress sınıflarını oluşturarak ilgili propertyleri ilgili sınıflarda oluşturup Ogrenci sınıfının alt üyesi olarak tanımladık. İleride ORM toolları kullanırlen çok işimize yarayacaktır. (Navigation property)
    internal class OgrenciOld
    {
        public string Adi { get; set; }

        public string SoyAdi { get; set; }

        public float Vize { get; set; }

        public float Final { get; set; }

        public float Ortalama { get; set; }

        public string AdresAdi { get; set; }

        public string AcikAdres { get; set; }

        public string Il { get; set; }
        public string Ilce { get; set; }
    }
}
