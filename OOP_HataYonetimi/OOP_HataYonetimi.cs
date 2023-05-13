using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HataYonetimi
{
    internal class OOP_HataYonetimi
    {
        static void Main(string[] args)
        {

            #region Hata


            #region Syntax / Söz Dizimi Hataları            

            // Yazılıma ilk başladığımız dönemlerde karşılaştığımız hatalardır.
            // Bazen noktalı virgülü unuturuz, bazen virgül, bazen de sayısal bir değişkene metinsel bir veri atarken karşımıza çıkar. Genellikle de kullandığımız editörler yardımı ile bu hataları yakalar ve düzeltiriz.
            // Bu tarz hataları editörümüz yakalamasa da Derleme(Build) aşamasında bize hata olarak geri dönecektir.

            // Söz dizimi hatası

            //if ()
            //{

            //}

            //int a
            //    string sehir;

            //int sayi1 sayi2;


            //sayi1 = "";

            #endregion

            #region Mantıksal Hatalar

            // Çözülmesi en zor hata türüdür...
            // Derleme aşamasında karşımıza çıkmayan hatalardır.
            // Veriden kaynaklı hatalar da değildir.
            // Fakat programın işleyişini doğru kurgulamamamızdan kaynaklanan hatalardır...
            // İstenen çıktıları vermeyen hatalardır.
            // Çözümü için de adım adım her satırı elimizdeki veriler ile kontrol ederek bulabileceğimiz hata türüdür.

            #endregion

            #region Çalışma Zamanı Hataları (Runtime Errors)

            // Kodumuzda herhangi bir derleme hatası olmadığında, yani syntax'ında herhangi bir sorun olmadığı durumlarda, programı derleyip çalıştırdıktan sonra çeşitli nedenler ile programda oluşan hatalardır..
            // Bu durumda işletim sistemi programa müdahale ediyor ve programın çalışmasını durduruyor.
            // Bu hatalar son kullanıcının karşılaştığı hatalardır.
            // Örneğin; olmayan bir dosyayı açmaya çalıştığımızda, sayısal bir veri beklenen noktada metinsel bir verinin gelmesi... Bu gibi durumlarda program çalışmasını durduracak..

            // System.FormatException
            // System.DivideByZeroException
            // System.IndexOutOfRangeException
            // System.NullReferenceException


            //int sayi;
            //Console.Write("Bir sayı giriniz..: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi * 2);

            //int sayi2;
            //Console.Write("İkinci sayıyı giriniz...: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bölme işleminin sonucu...: " + (sayi/sayi2));


            //int[] sayilar = new int[2];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;


            //Product product = null;

            //Console.WriteLine(product.Name);


            try
            {
                // Hata alma olasılığı olan kodlarımızı buraya yazıyoruz.
                // Eğer kodlarda bir hata oluşmaz ise try-catch bloğunun dışına çıkıp çalışmasına devam edecek..

                // Eğer ki buradaki kodlarda bir hata söz konusu olursa, bu durumda program sonlanmayacak, çalışmasına catch bloğundan devam edecek.
            }
            catch (Exception)
            {
                // try bloğunda bir hata ile karşılaşılırsa program çalışmasına buradan devam edecek.
                
            }
            // try - catch bloğunun dışı

            try
            {
                int sayi;
                Console.Write("Bir sayı giriniz..: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi * 2);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("girdiğiniz değer sayısal bir değer değildir...");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("bir sayı sıfıra bölünemez..");
                Console.WriteLine(ex.Message + ex.StackTrace);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Bir hata oluştu..");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                // try bloğundaki kodlar çalıştıktan sonra finally bloğuna gelir ve buradaki kodlar çalıır.
                // Eğer try bloğunda bir hata oluştuysa, catch bloğundaki kodlar çalışır. catch bloğundaki kodların çalışması bittikten sonra finally bloğundaki kodlar çalışır.
                // Yani finally bloğu her zaman çalışır.
                // Örnek: veritabanı işlemlerinde sıklıkla kullanılır.

                Console.WriteLine("Burası finally bloğu");

            }

            Console.WriteLine("program sonu");

            Console.ReadLine();

            #endregion

            #endregion

        }
    }

    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
