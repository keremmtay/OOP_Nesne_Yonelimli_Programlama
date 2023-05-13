using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static_Classlar
{
    internal class OOP_Static_Classlar
    {
        static void Main(string[] args)
        {

            #region static  olmayan Class'lar

            //Araba araba = new Araba();
            //araba.Metot1();


            #endregion


            #region Static Keyword'ü

            // Static Class'lar static üyeler sahip olmak zorundadır.
            // Static Class'lar new'lenemezler. New keyword'ü ile nesnesi oluşturulamaz.

            // ArabaStatic arabaStatic = new ArabaStatic();

            // Static bir elemana ulaşmak istediğimizde Class adını yazıp içindeki static elemanlara ulaşabiliriz.

            // Bir sınıfı miras olarak alamazlar.

            // Hangi durumlarda static Class tercih edilir? Nesneye bağımlı olmayan işlemlerin yapıldığı durumlarda static Classlar kullanılabilir.

            // Static olmayan Class içinde static üyelere sahip olabilir.

            // Static olmayan Class içindeki static elemanlara ulaşırken new'leme yapılmasına gerek yoktur.

            // new'lediğimiz bir Class'ın iiçnde yani nesne içinden static elemanlara ulaşamayız.

            Araba.Metot2Static();

            ArabaStatic.MetotStatic();

            #endregion

            #region Static Yapıcı Metot / Constructor

            /// Constructor static olarak tanımlanmışsa ve başka constructorlar da var ise öncelikli olarak static olan yapıcı metot çalışır. Daha sonra diğerleri çalışır.
            /// Static yapıcı metot parametre almaz.
            /// Static yapıcı metot kaç nesne örneği olursa olsun bir kere çalışır.
            /// Bir sınıf sadece bir tane yapıcı metota sahip olabilir


            #endregion

            Console.ReadLine();

        }
    }

    class Araba
    {

        public int Id { get; set; }

        public void Metot1()
        {

            Console.WriteLine("Klasik Class ve metodumuz......");

        }

        public static void Metot2Static()
        {

            Console.WriteLine("static olmayan class içindeki static metodumuz.");

        }

    }

    static class ArabaStatic
    {

        public static int Id { get; set; }

        public static void MetotStatic()
        {

            Console.WriteLine("Static Class içindeki metodumuz");

        }

    }
}
