using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Girinz");
            int kilo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            
            double bke = kilo / (boy * boy);
            Console.WriteLine("BKE : " + bke);

            if (bke >=18 && bke <=25)
            {
                Console.WriteLine("NORMAL");
            }
            else if (bke <= 18)
            {
                Console.WriteLine("ZAYIF");
            }
            else if(bke > 25) 
            {
                Console.WriteLine("OBEZ");
            }
            Console.ReadLine();








        }
    }
}
