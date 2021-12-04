using System;

namespace GenericClasesss
{
    class Program
    {
        static void Main(string[] args)
        {
            // Şablon tiplerin en önemli özelliği tipin instance aşamasında oluşmasıdır...
            Not<int> not1 = new Not<int>();
            not1.Vize = 50;

            Not<float> not2 = new Not<float>();
            not2.Vize = 50.99f;

            Not<string> not3 = new Not<string>();
            not3.Vize = "AA";


            // struct value tpyleri, class referans typeleri temsil eder...

            // hesapmakinesi,....

            HesapMakinesi<int> he = new HesapMakinesi<int>();

            //HesapMakinesi<string> str = new HesapMakinesi<string>(); bu şekilde instance alınamaz çünkü, t sadece struct(int,byte,short,sbyte,uing,long,decimal, vb..) olabilir...

            Console.WriteLine("Hello World!");
        }
    }
}
