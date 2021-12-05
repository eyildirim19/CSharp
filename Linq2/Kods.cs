using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public class Ogrenci
    {
        public string AdiSoyAdi { get; set; }
        public char Cinsiyet { get; set; }
        public Not Notu { get; set; }
    }

    public class Not
    {
        public float Vize { get; set; }

        public float Final { get; set; }

        public float Ortalama
        {
            get
            {
                return Vize * 0.4f + Final * 0.6f;
            }
        }
    }

}

