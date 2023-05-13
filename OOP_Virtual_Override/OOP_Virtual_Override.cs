using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Virtual_Override
{
    internal class OOP_Virtual_Override
    {
        static void Main(string[] args)
        {

            // Bazen inherite edilen sınıftaki bazı property ya da metotlar, miras alınan her sınıf için geçerli olmayabiliyor. Bu gibi durumlarda base Class'taki  ilgili elemanlar virtual keyword'ü ile işaretlenir.
            // Bu elemanları kullanmak istemeyen child sınıflar override keyword'ünü kullanarak kendi metotlarını/propertylerini yazabilirler/kullanabilirler.

            Cocuk cocuk = new Cocuk();
            cocuk.MetotBaba();

            Console.ReadLine();
        }
    }

    class Baba
    {

        public string BabaAdi { get; set; }

        public virtual void MetotBaba()
        {

            Console.WriteLine("Baba sınıfı içerisindeki metot");

        }

    }

    class Cocuk : Baba
    {

        public string CocukAdi { get; set; }

        public void MetotCocuk()
        {

            Console.WriteLine("Çocuk sınıfı içindeki metot");

        }
        public override void MetotBaba()
        {

            Console.WriteLine("Çocuk sınıfı içerisindeki MetotBaba metodu");

        }

    }



}
