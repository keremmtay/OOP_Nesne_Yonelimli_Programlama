using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek3_Inheritance
{
    internal class OOP_Ornek3_Inheritance
    {
        static void Main(string[] args)
        {

            Personel personel = new Personel();
            personel.Id = 1;
            personel.Adi = "Ali";
            personel.Soyadi = "Kaya";
            personel.AktifMi = true;
            personel.Departman = "IT";

            Musteriler musteriler = new Musteriler();
            musteriler.Adi = "Ahmet";
            musteriler.FirmaAdi = "ABC Firması";


        }
    }

    class Kisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Adres { get; set; }



    }

    class Personel : Kisi
    {
      
        public bool AktifMi { get; set; }
        public string Departman { get; set; }
        public int Yas { get; set; }
        public double Maas { get; set; }



    }


    class Musteriler : Kisi
    {
        
        public string FirmaAdi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }


    }







    //class A
    //{


    //}
    //class B : A
    //{


    //}
    //class C : B
    //{


    //}
    //class D : C
    //{


    //}
}
