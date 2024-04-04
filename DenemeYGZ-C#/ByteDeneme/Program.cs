using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişken tanımladım.
            byte birinci = 5;
            byte ikinci = 3;
            byte üçüncü = 2;
            byte dördüncü = 1;  //0-255
            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;


            Console.WriteLine(maxDeger);
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(üçüncü);
            Console.WriteLine(dördüncü);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
