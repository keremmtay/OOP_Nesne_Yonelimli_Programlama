using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nested_Classlar
{
    internal class OOP_Nested_Classlar
    {
        static void Main(string[] args)
        {

            #region Nested / İçiçe Classlar

            // KENDİ NOTUM:::
            //
            // Class içinde class oluşturmak için, içerideki o class'ın büyük olana hizmet etmesi zorunludur. Kullanım şekli metotlara benzerdir ancak o da başlı başına bir class gibi davranır.

            // HOCA NOTU::::
            //
            // Bir Class'ın içinde, bir takım operasyonlar yapıyorsak ve bu operasyonlarımıza yardımcı olacak bir Class ihtiyacımız var ise bu durumda Nested/İçiçe Class'ları kullanabiliriz.
            // Nested Class'ın sadece içinde tanımladığı Class'a hizmet etmesi gerekir.

            #endregion

            Ornek ornek = new Ornek(3, 5);

            ornek.Sonuc();

            Console.ReadLine();

        }

      
    }





    class Ornek
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Ornek(int number1, int number2)
        {

            Number1 = number1;
            Number2 = number2;
        }
        

        public void Sonuc()
        {

            Ornek1 ornek1 = new Ornek1();
            ornek1.Topla(Number1, Number2);

        }

        class Ornek1

        {
            public void Topla(int sayi1, int sayi2)
            {

                Console.WriteLine(sayi1 + sayi2);

            }


        }


    }
}
