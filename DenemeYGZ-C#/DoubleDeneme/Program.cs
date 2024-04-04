using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 byte yer kaplar
            //15 basamaklı ondalık sayılarıda tutabilir.


            double ondalikli_sayi = 23.34;

            double ondalikli_sayi2 = -23.45;

            double MaxDeger= double.MaxValue;
            double MinDeger= double.MinValue;


            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);
            Console.WriteLine(ondalikli_sayi);
            Console.WriteLine(ondalikli_sayi2);
            Console.ReadLine();
        }
    }
}
