using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Collections_Koleksiyonlar
{
    internal class OOP_Collections_Koleksiyonlar
    {
        static void Main(string[] args)
        {

            #region Collections / Koleksiyonlar

            //int[] sayilar = new int[5];
            //sayilar[0] = 12;
            //sayilar[1] = 13;
            //sayilar[2] = 14;
            //sayilar[3] = 15;
            //sayilar[4] = 16;

            //int[] sayilar1 = new int[10];
            //sayilar1[0] = 1;
            //sayilar1[1] = 2;
            //sayilar1[2] = 3;

            // Aynı türde verileri bir dizi içinde tutabiliyoruz.
            // Eleman sayısını önceden bildirmek zorundayız.
            // Örn; 10 elemanlı bir dizi tanımladık. Ayrılan bu, bu bölgeye veri atamasak dahi memory'de yer kaplıyor.
            // Performans açısından kötü...
            // Veri atarken ve okurken maliyeti yüksek..

            #endregion

            #region ArrayList

            // OOP'da ilk koleksiyondur. Diğer koleksiyonların atasıdır.
            // Eleman sayısını belirtmeye gerek yok. Veri ekledikçe eleman sayısı otomatik olarak artıyor.
            // Memory'de eleman sayısı kadar yer kaplıyor.
            // Performansları dizilere göre daha iyi.
            // ArrayList kullanabilmek iççin System.Collections kütüphanesi sayfamıza eklememiz gerekecek.

            ArrayList list = new ArrayList();
            // ArrayList object türünden tüm elemanları alabilir.
            // object türünden veriler aldığı için, tip güvenli değildir. Yani sadece string verileri tutmak istediğimde sayısal veri atamamın önünde bir engel yok...

            // Veriler arka planda indekslenerek saklanıyor.
            // Veri okumak istediğimizde indeks numaralarından faydalanabiliriz.

            list.Add(15);
            list.Add(35);
            list.Add(false);
            list.Add(true);
            list.Add('K');
            list.Add("İstanbul");
            list.Add(new Kategori());


            // Tek bir veriyi okurken indeks numarasını kullanabiliriz.
            //Console.WriteLine(list[0]);

            // Eğer bütün verileri almak istiyorsam

            foreach (var item in list)
            {
                //Console.WriteLine(item);
            }


            #endregion

            #region List

            // ArrayList object türünden bir değer alırken, List koleksiyonu generic bir yapıya sahiptir. Yani özelleştirilmiş bir tip alır.
            // List<VeriTipi> degiskenIsmi = new List<VeriTipi>();


            List<int> numbers = new List<int>();
            List<string> sehirler = new List<string>();
            List<Kategori> kategoriler = new List<Kategori>();

            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Adana");
            sehirler.Add("Trabzon");

            //sehirler.Add(15); 
            //sehirler.Add('K'); 
            //sehirler.Add(false);

            // Listler tür güvenli olduğundan dolayı string olarak tanımlanan listlere başka tür bir veri ekleyemeyiz.

            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);

            // sehirler koleksiyonunun içindeki tüm veriler içinde gezmek istiyorsam döngülerden faydalanabilirim...

            //Console.WriteLine("Sehirler listesinin boyutu...: " + sehirler.Count);

            //for (int i = 0; i < sehirler.Count; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //Console.WriteLine("foreach");
            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            #endregion

            //Kategori kategori1 = new Kategori()
            //{

            //    Id = 1,
            //    KategoriAdı = "Telefon"

            //};
            //Kategori kategori2 = new Kategori()
            //{

            //    Id = 2,
            //    KategoriAdı = "Elektronik"

            //};
            //Kategori kategori3 = new Kategori();
            //kategori3.Id = 3;
            //kategori3.KategoriAdı = "Beyaz Eşya";

            //kategoriler.Add(kategori1);
            //kategoriler.Add(kategori2);
            //kategoriler.Add(kategori3);


            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine(kategori);
            //}

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }

            //sehirler.Remove("Adana");

            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("******************************");

            //sehirler.RemoveAt(2);

            //sehirler.RemoveRange(2, 2);

            //Console.WriteLine(sehirler.Contains("İstanbul"));
            //Console.WriteLine(sehirler.Contains("Kars"));
            //sehirler.Sort(); // Alfabetik ya da büyükten küçüğe göre sıralama yapıyor.
            //sehirler.Reverse(); // Diziyi tersine çeviriyor.. Sondaki veriyi en başa alarak bir sıralama yapıyor. Küçükten büyüğe şeklinde sıralama yapmak için öncesinde Sort kullanmak zorunludur.

            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Muğla");
            sehirler1.Add("Eskişehir");
            sehirler1.Add("Zonguldak");

            sehirler.AddRange(sehirler1); // sehirler listesine sehirler1 içindeki veriler eklendi..

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }


        }
    }

    class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdı { get; set; }

    }
}
