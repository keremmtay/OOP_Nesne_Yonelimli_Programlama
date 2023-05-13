using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    public class Urun
    {
        // Fiziksel olarak ilk class'ımızı oluşturduk.

        public int Id { get; set; }

        public string Name { get; set; }

        public string KategoriAdi { get; set; }

        public double Fiyat { get; set; }

        public void BilgileriYaz()
        {

            Console.WriteLine($"Id....: {Id} - Ürün Adı...: {Name} - Kategori Adı...: {KategoriAdi} - Fiyat...: {Fiyat}");

        }


    }
}
