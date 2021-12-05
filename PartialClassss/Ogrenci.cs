using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassss
{

    // Partial sınıflar ayrı geliştirilip instance aşamasında birleşen sınıflarıdır...

    public partial class Ogrenci
    {
        public string Adi { get; set; }
    }

    public partial class Ogrenci
    {
        public string SoyAdi { get; set; }
    }
}
