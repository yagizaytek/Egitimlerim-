using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopluDneme
{
    public class Ogrenci
    {

        private int ogrno;

        private string isim;

        private string soyisim;

        private int vize1;

        private int vize2;

        private int final;

        private string okulismi;



        public Ogrenci(int _ogrno ,string _isim , string _soyisim , int _vize1 , int _vize2 , int _final , string _okulismi)
        {
            ogrno = _ogrno;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }


        public void ogrencibilgilerigoster()
        {
            Console.WriteLine("Öğrenci Numarası :" + ogrno);
            Console.WriteLine("Öğrenci ismi :" + isim);
            Console.WriteLine("Öğrenci soyismi :" + soyisim);
            Console.WriteLine("Öğrenci vize1 Notu :" + vize1);
            Console.WriteLine("Öğrenci vize2 Notu :" + vize2);
            Console.WriteLine("Öğrenci Final Notu :" + final);
            Console.WriteLine("Öğrenci Okul İsmi :" + okulismi);

        }

        public double ogrencinotubul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

            return ortalama;
        }



        public void okulgetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi :"+ okulismi);
        }

    }
}
