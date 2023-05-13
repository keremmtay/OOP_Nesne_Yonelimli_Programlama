using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Contructor_Yapici_Metodlar
{
    internal class OOP_Contructor_Yapici_Metodlar
    {
        static void Main(string[] args)
        {
            #region Yapici Metodlar

            //Ogrenci ogrenci = new Ogrenci("Ali");   // Ogrenci() aslında ilgili sınıfın constructor'ıdır.

            Ogrenci ogrenci1 = new Ogrenci(5, "Ali", "Kaya");

            Console.WriteLine(ogrenci1.Isim);
            Console.WriteLine(ogrenci1.Soyisim);
            Console.WriteLine(ogrenci1.OgrenciNo);


            #endregion

            Console.ReadLine();
        }
    }
}
