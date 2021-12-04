using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasesss
{

    // Generic Yapılar(şablon tipler) => İnstance alınırken tipin belirlendiği yapılardır. Genericler proje içerisinde tip güvenliği (saldırı vs. değil) sağlamak için kullanılır... Generic operatörü <> 'dür. Bu operatörün içerisinde instance alınırken verilecek tipin templatae verilir.
    //Not : generic tip belirleken <> içerisine verilecek isim T olmalıdır. Type'in ilk harfi.
    public class Not<T> // tip burada template temsil eder..tip instance alınırken belirlenir.
    {
        public T Vize { get; set; }
        public T Final { get; set; }
        public T Ortalama { get; set; }
    }

    // generic tiplerde instance aşamasında tip kıtılamsı getirilebilir. Bunu where ile  : ile tipin ne olacağını belirtebiliriz...Örnekte T'nin sadece struct tipinde olacabileceğini belirttik...
    public class HesapMakinesi<T> where T : struct
    {
        public T Sayi1 { get; set; }
        public T Sayi2 { get; set; }
    }
}