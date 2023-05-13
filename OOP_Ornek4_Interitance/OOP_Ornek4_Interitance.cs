using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek4_Interitance
{
    internal class OOP_Ornek4_Interitance
    {
        static void Main(string[] args)
        {
            // Örnek: Emlak sitesi, kiralık ve satılık verilerini tutacağımız class'larımız olacak. Bunlar modellenecek. Inheritance kullanılacak.
        }
    }

    class İlan
    {
        public string Id { get; set; }
        public string Adres { get; set; }
        public int Büyüklük { get; set; }
        public double Fiyat { get; set; }
        public string OdaSayisi { get; set; }
        public string BinaYasi { get; set; }
        public bool BahceVarMi { get; set; }
        public bool Dogalgaz { get; set; }


    }

    class Satilik : İlan
    {

        public bool KrediyeUygunluk { get; set; }
        public bool EsyaliMi { get; set; }
        public double Taksit { get; set; }


    }
    
    class Kiralik : İlan
    {
        public double Depozito { get; set; }
        public DateTime SozlesmeSuresi { get; set; }
        public int Aidat { get; set; }

    }
}
