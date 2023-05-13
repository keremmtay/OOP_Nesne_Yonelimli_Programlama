using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek1
{
    internal class Ogrenci
    {
        public int OgrenciNo { get; set; }

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public int Yas { get; set; }

        public int Sınıf { get; set; }

        public char Sube { get; set; }

        public char Cinsiyet { get; set; }

        public void BilgileriYaz()
        {

            Console.WriteLine($"\n\nÖğrenci numarası:\t{OgrenciNo}\nÖğrencinin ismi:\t{Isim}\nÖğrencinin soyismi:\t{Soyisim}\nÖğrencinin yaşı:\t{Yas}\nÖğrencinin Sınıfı:\t{Sınıf}\nÖğrencinin Şubesi:\t{Sube}\nÖğrencinin Cinsiyeti:\t{Cinsiyet}");
        }
    }
}
