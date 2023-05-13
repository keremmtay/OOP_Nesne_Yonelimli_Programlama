using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    internal class OOP_Class
    {
        static void Main(string[] args)
        {

            //Urun x = new Urun();

            Urun x = new Urun();            // buradaki veriler fiziksel olarak tanımladığımız class içerisinden geliyor.
            x.Id = 1;
            x.Name = "Iphone";
            x.KategoriAdi = "Telefon";
            x.Fiyat = 150;

            x.BilgileriYaz();

            Console.ReadLine();
        }
    }

    // Aynı dosya içerisinde bu şekilde class tanımlayabiliyoruz.
    //public class Urun
    //{

    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public string KategoriAdi { get; set; }

    //    public double Fiyat { get; set; }

    //}
}
