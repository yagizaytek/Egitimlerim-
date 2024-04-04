using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopluDneme
{
    public class Program
    {
        private static string ogrenciortalama;

        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1, " Osayi", "Samuel", 40, 55, 78, "Fenerbahçe Üniversitesi");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz...Yapak İstediğiniz İşlemi Seçiniz");
            

            while(true) 
            {
                islemlerigoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        ogrenci1.ogrencibilgilerigoster();
                        break;
                        

                        case "2":

                        double ortalama= ogrenci1.ogrencinotubul();
                        Console.WriteLine("Öğrencinin Ortlaması : "+ ortalama);

                        break;

                        case "3":

                        ogrenci1.okulgetir();

                        break; 
                    
                    case "4":

                        kontrol = false;

                        break;

                }
            }

            
        }

        private static void ogrencinotubul()
        {
            throw new NotImplementedException();
        }

        static void islemlerigoster()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");

        }
    }
}
