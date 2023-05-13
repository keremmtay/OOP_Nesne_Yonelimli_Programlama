using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek2
{
    internal class OOP_Ornek2
    {
        static void Main(string[] args)
        {

            // Örneğin benim bir araba nesnesine ihtiyacım var ise öncelikli olarak yapmam gereken şey araba nesnesini modellemem gerekecek.
            // Bir class'tan nesne oluşturmak için birkaç yol var.

            // 1. Yol:

            Araba araba = new Araba();
            araba.Marka = "Mercedes";
            araba.Model = "C Serisi";            
            araba.ModelYili = 2023;
            araba.Renk = "Siyah";

            araba.Calis();
            araba.Hızlan();
            araba.Yavasla();
            araba.Dur();

            // 2. Yol:

            Araba araba1 = new Araba()
            {
                Marka = "BMW", 
                Model = "3.16 ",
                ModelYili = 2022,
                Renk = "Kırmızı"

            };
            araba1.Calis();
            araba1.Hızlan();
            araba1.Yavasla();
            araba1.Dur();

            // 3. Yol: Constructor kullanarak veri ataması yapılabilinir

            Araba araba2 = new Araba("Fiat", "Doğan görünümlü Şahin", 1990, "Beyaz");

            //araba2.Yavasla();

            Console.ReadLine();
        }
    }

    // Nesnemizin modellemesini aşağıdaki gibi yapmış olduk.

    public class Araba
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public int ModelYili { get; set; }

        public string Renk { get; set; }

        // Constructor: yapıcı metodumuz.
        // Constructor public olmak zorunda eğer bir nesne oluşturmak istiyorsak.
        // Parametreli constructor kullanmak istiyorsak bir adet de parametresiz, boş constructor oluşmamız gerekmektedir.

        public Araba(string marka, string model, int modelYili, string renk)
        {
            Marka = marka;
            Model = model;
            ModelYili = modelYili;
            Renk = renk;
        }

        public Araba()
        {

        }

        public void Calis()
        {
            Console.WriteLine(Marka + " için araç çalıştı.");

        }

        public void Dur()
        {
            Console.WriteLine(Marka + " için araç durdu.");

        }

        public void Hızlan()
        {
            Console.WriteLine(Marka + " için araç hızlanıyor.");

        }

        public void Yavasla()
        {
            Console.WriteLine(Marka + " için araç yavaşlıyor.");

        }



    }


}
