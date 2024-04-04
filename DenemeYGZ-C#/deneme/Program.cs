using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not gir");
            int not =Convert.ToInt32(Console.ReadLine());  

                if(not >= 50) 
            {
                Console.WriteLine("öğrenci bu dersten başarılı geçti");

            }
                else 
            {
                Console.WriteLine("öğrenci bu dersten başarısız oldu");
                Console.ReadLine();
                    }
        }
    }
}
