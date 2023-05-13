using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Contructor_Yapici_Metodlar
{
    internal class Ogrenci
    {
        public int OgrenciNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        // Sınıftan ilk nesne oluşturulurken, değerlerini vererek oluşturabilirim.

        public Ogrenci(int ogrenciNo, string isim, string soyisim)
        {
            OgrenciNo = ogrenciNo;
            Isim = isim;
            Soyisim = soyisim;
        }

        // Yapıcı metotlar her sınıfta bulunur. Bir sınıftan bir nesne oluştururken, Constructor'lar bu nesneyi yapılandırmak için kullanılır.
        // Aşağıdaki metod bu sınıf için oluşturulan bir constructor/yapıcı metodtur.
        // Bir metodun yapıcı metod olabilmesi için sınıf ile aynı isme sahip olması gerekir.
        // Yapıcı metotlar parametresiz tanımlanabildiği gibi, parametre alan constructor'lar da tanımlanabilir.
        // Metodlarda olduğu gibi Overload Constructor'lar için de geçerlidir. Birden fazla constructor tanımlanabilir.
        public Ogrenci()
        {



        }
        public Ogrenci(string isim)
        {

            // Bu sınıftan bir nesne oluşturduğumuzda ilk çalışan yer constructor'dır.
            Console.WriteLine("Burası Ogrenci sınıfının yapıcı metodudur.");
            Console.WriteLine(isim);

        }

        public Ogrenci(string isim, string soyisim)
        {

        }

    }
}
