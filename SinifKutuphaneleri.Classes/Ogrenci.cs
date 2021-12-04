using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifKutuphaneleri.Classes
{
    // public proje içerisinden ve proje dışından 
    public class Ogrenci
    {
        public string Adi { get; set; }

        public string SoyAdi { get; set; }

        public Nots Notu { get; set; }

        public Adres Adresi { get; set; }
    }
}