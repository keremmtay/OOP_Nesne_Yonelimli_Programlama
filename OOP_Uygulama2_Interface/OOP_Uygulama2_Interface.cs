using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulama2_Interface
{
    internal class OOP_Uygulama2_Interface
    {
        static void Main(string[] args)
        {

            // 

            //Oracle oracle = new Oracle();
            //oracle.Add();
            //oracle.List();


            //MsSql msSql = new MsSql();
            //msSql.Add();
            //msSql.List();


            IDatabase db = new MySql();
            db.Add();
            db.Delete();
            db.Update();
            db.List();
            db.Find();
            db.FindByName();
            db.FindByCity();
            //db.ABC();

            Oracle db1 = new Oracle();
            db1.ABC();
            IArayuz db2 = new Oracle();
            db2.ABC();


            Console.ReadLine();
            
        }
    }

    interface IArayuz
    {
        void ABC();
    }

    interface IDatabaseFind
    {
        void FindByName();
        void FindByCity();

    }

    interface IDatabase : IDatabaseFind// , IArayuz
    {
        void Add();
        void List();
        void Delete();
        void Update();
        void Find();
    }

    class Oracle : IDatabase, IArayuz
    {
        public void ABC()
        {
            Console.WriteLine("Oracle veritabanına göre ABC metodu göre bulundu..");
        }

        public void Add()
        {
            Console.WriteLine("Veri Oracle veritabanına eklendi..");
        }

        public void Delete()
        {
            Console.WriteLine("Veri Oracle veritabanından silindi..");
        }

        public void Find()
        {
            Console.WriteLine("Veri Oracle veritabanında bulundu..");
        }

        public void FindByCity()
        {
            Console.WriteLine("Veri Oracle veritabanında şehre göre bulundu..");
        }

        public void FindByName()
        {
            Console.WriteLine("Veri Oracle veritabanında isme göre bulundu..");
        }

        public void List()
        {
            Console.WriteLine("Veri Oracle veritabanında listelendi..");
        }

        public void Update()
        {
            Console.WriteLine("Veri Oracle veritabanında güncellendi..");
        }


    }

    class MsSql : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Veri MsSQL veritabanına eklendi..");
        }

        public void Delete()
        {
            Console.WriteLine("Veri MsSQL veritabanından silindi..");
        }

        public void Find()
        {
            Console.WriteLine("Veri MsSQL veritabanında bulundu..");
        }

        public void FindByCity()
        {
            Console.WriteLine("Veri MsSQL veritabanında şehre göre bulundu..");
        }

        public void FindByName()
        {
            Console.WriteLine("Veri MsSQL veritabanında isme göre bulundu..");
        }

        public void List()
        {
            Console.WriteLine("Veri MsSQL veritabanında listelendi..");
        }

        public void Update()
        {
            Console.WriteLine("Veri MsSQL veritabanında güncellendi..");
        }
        public void ABC()
        {
            Console.WriteLine("MsSQL veritabanına göre ABC metodu göre bulundu..");
        }
    }

    class MySql : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Veri MySQL veritabanına eklendi..");
        }

        public void Delete()
        {
            Console.WriteLine("Veri MySQL veritabanından silindi..");
        }

        public void Find()
        {
            Console.WriteLine("Veri MySQL veritabanında bulundu..");
        }

        public void FindByCity()
        {
            Console.WriteLine("Veri MySQL veritabanında şehre göre bulundu..");
        }

        public void FindByName()
        {
            Console.WriteLine("Veri MySQL veritabanında isme göre bulundu..");
        }

        public void List()
        {
            Console.WriteLine("Veri MySQL veritabanında listelendi..");
        }

        public void Update()
        {
            Console.WriteLine("Veri MySQL veritabanında güncellendi..");
        }
        public void ABC()
        {
            Console.WriteLine("MySQL veritabanına göre ABC metodu göre bulundu..");
        }
    }
}
