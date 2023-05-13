using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek1
{
    internal class OOP_Ornek1
    {
        static void Main(string[] args)
        {

            // Ogrenci sınıfımız.. Verilerimizi tutmak için bir takım propertyler olacak
            // Öğrenci no, Adı, Soyadı, Şubesi, Cinsiyeti, Yaşı
            // Klavyeden girdiğimiz öğrenci bilgilerini Ogrenci sınıfından oluşturduğumuz nesnemizin içine yerleştireceğiz..
            // Nesne içerisinden okuyarak bu bilgileri ekrana yazdıralım. Ekrana yazdıracak kodları da Sınıf içerisindeki bir metot ile yapalım.

            Ogrenci x = new Ogrenci();
            Console.WriteLine("Öğrencinin numarasını giriniz:");
            x.OgrenciNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrencinin ismini giriniz:");
            x.Isim = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Öğrencinin soyismini giriniz:");
            x.Soyisim = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Öğrencinin yaşını giriniz:");
            x.Yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrencinin sınıfını giriniz:");
            x.Sınıf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrencinin şubesini giriniz:");
            x.Sube = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Öğrencinin cinsiyetini giriniz:");
            x.Cinsiyet = Convert.ToChar(Console.ReadLine());

            x.BilgileriYaz();

            Console.ReadLine();
        }
        

    }
    

}
