using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class OOP_Interface
    {
        static void Main(string[] args)
        {

            #region Interface / Arayüz

            /// Interface Nedir? Yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
            /// Yapısı Classlar gibidir. Ama ayrı bir kavram olarak düşünülmelidir. 
            /// Constructor'ları olmadığı için newlenemezler. Yani nesneleri oluşturulamaz.
            /// Fakat kendisini implement eden sınıfların referansını tutabilirler. Bu bize çok esnek bir yapı kurulmasını sağlıyor... Dessign Pattern'larda (tasarım deseni) çok sık kullanılır.
            /// Interface'ler sadece property'lerin ve metotların imzalarını barındırır. Veri ya da metot gövdesi barındırmaz... Gövdeleri kendisini implement eden sınıflarda doldurulur. 
            /// Yapıları yol gösterici nitelikte olduğu için Class'lar ile birlikte kullanılır. 
            /// Bir Class'a implement edildiğinde, o Class içinde bütün özellikleri tanımlamalıyız.
            /// Bir interface başka bir interface'i miras olarak alabilir.
            /// Bir class sadece bir Class'ı miras olarak alabilirken, birden fazla interface'i implement edebilir.
            /// Interface içerisinde bulunan bütün elemanlar erişim belirleyicisi (Access Modifier) public olarak kabul edilir. Bu yüzden Access Modifier kullanılmaz.
            /// Interface için isimlendirme yaparken mutlaka Interface'in I harfi ile başlar...
            /// 

            // Interface imzası:

        //    interface Iinterfaceİsmi
        //{
        //    // İmplement edilecek sınıfların zorunlu olarak kullanacağı property'ler ve/veya metotlar burada tanımlanır.
        //}

            // interface'in kullanım amacı : (ilk etapta):
            #endregion

        }
    }

    interface IKisi
    {
        int Id { get; set; }
        string Name { get; set; }

        void MaasHesapla();
    }

    class Calisan : IKisi
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void MaasHesapla()
        {
            
        }
    }
    class BaskaBirClass : IKisi
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
