using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Collections2
{
    internal class OOP_Collections2
    {
        static void Main(string[] args)
        {

            #region Hashtable

            // Key ve Value mantığına göre verileri tutar.
            // Key unique olmalı.

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1,"Adana");
            hashtable.Add(6, "Ankara");
            hashtable.Add(34, "İstanbul");
            hashtable.Add(35, "İzmir");
            hashtable.Add(41, "Kocaeli");
            hashtable.Add(2, true);
            hashtable.Add(5, 'K');
            hashtable.Add(7, 123);

            //Console.WriteLine(hashtable[2]);


            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //hashtable.Clear();
            //Console.WriteLine("****************");
            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*******  GetType() *********");

            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item.GetType());
            //}

            #endregion

            #region HashSet<Type>

            // Sadece tanımlanan tipteki verileri tutar.
            // Aynı değerdeki veri tekrar eklenmek istendiğinde hata vermez fakat aynı veriyi ikinci defa eklemez.

            HashSet<int> values = new HashSet<int>();
            values.Add(1);
            values.Add(6);
            values.Add(-42);            
            values.Add(666);
            values.Add(39);
            values.Add(-42);

            Console.WriteLine("************* HashSet<Type> ************");

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Dictionary

            // Tip güvenli bir şekilde verilerimizi key, value mantığına göre tutabiliriz.

            Dictionary<int, string> sozluk = new Dictionary<int, string>();

            sozluk.Add(1, "One");
            sozluk.Add(2, "Two");
            sozluk.Add(3, "Three");

            //Console.WriteLine(sozluk[2]);
            string veri = sozluk[2];
            Console.WriteLine(veri);

            #endregion

        }
    }
}
