using System;

namespace IOC_DI.ConsoleAppOneClass
{
    // Inversion Of Control (IOC) : Principle (Principle:Programlama yaparken bize yol gösteren rehberlerdir ör.SOLID)
    // Dependency Inversion (DIP) : Principle
    // Dependency Injection (DI)  : Pattern
    // Inversion of Control Container (IoCC) : Framework (Ninject, Autofact, Unity)

    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer businessLayer = new BusinessLayer(new DataAccessLayer());
            businessLayer.GetProducts().ForEach(x => { Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}"); });
        }

        class BusinessLayer
        {   // BusinessLayer : Depended (Bağlı) nesne ?= görevini yerine getirebilmesi için başka nesnelere yardımcı olur
            // sıkı bağlılık var. (tightly coupled) design patternler ile gevşeteceğiz
            private IDataAccessLayer IdataAccessLayer { get; set; }
            public BusinessLayer(IDataAccessLayer dataAccessLayer)

            {
                IdataAccessLayer = dataAccessLayer;  // DataAccessLayer : Dependency (Bağımlı) nesne ?= görevini yerine getirebilmesi için başka bir nesneye ihtiyaç duyar
                IdataAccessLayer = DALFactory.GetDal();
                IdataAccessLayer.GetProducts();

                // Factory Pattern implement ettik
                // IdataAccessLayer = DALFactory.GetDalCips();  
                // IdataAccessLayer = DALFactory.GetDalKola();  

            }
            public List<Product> GetProducts()
            {
                return IdataAccessLayer.GetProducts();
            }
        }

        class DALFactory
        {
            // Factory Pattern : Factory tasarım deseni; nesne örneği üretmek için.
            public static IDataAccessLayer GetDal()
            {
                return new DataAccessLayer();
            }
            public static IDataAccessLayer GetDalKola()
            {
                return new DataAccessLayerKola();
            }

            public static IDataAccessLayer GetDalCips()
            {
                return new DataAccessLayerCips();
            }
        }

        // Factory classını generic yapmaya çalıştım yapamadım. 
        //public IDataAccessLayer DALFactory2(IDataAccessLayer dataAccessLayer)
        //{
        //    Oyun oyun = null;
        //    switch (typevalue)
        //    {
        //        case typ  IDataAccessLayer.DataAccessLayerKola:
        //            oyun = new DataAccessLayerKola();
        //            break;
        //        case Oyunlar.PC:
        //            oyun = new PC();
        //            break;
        //        case Oyunlar.PS:
        //            oyun = new PS();
        //            break;
        //    }
        //    return oyun;
        //}

        //enum Ürünler
        //{
        //    MAl,
        //    Cips,
        //    Kola
        //}

        interface IDataAccessLayer
        {
            List<Product> GetProducts();
            //int Hesapla();
        }

        class DataAccessLayer : IDataAccessLayer
        {
            public List<Product> GetProducts()
            {   // SQL server
                return new List<Product>
            {
                new Product{Id=1,Name="Ürün1",Price=100,Stock=200},
                new Product{Id=2,Name="Ürün2",Price=200,Stock=200},
                new Product{Id=3,Name="Ürün3",Price=300,Stock=200},
                new Product{Id=4,Name="Ürün4",Price=400,Stock=200},
            };
            }

            public int Hesapla() { return 100; }
        }

        class DataAccessLayerKola : IDataAccessLayer
        {
            public List<Product> GetProducts()
            {   // Oracle
                return new List<Product>
            {
                new Product{Id=1,Name="KOlA1",Price=100,Stock=200},
                new Product{Id=2,Name="KOlA2",Price=200,Stock=200},
                new Product{Id=3,Name="KOlA3",Price=300,Stock=200},
                new Product{Id=4,Name="KOlA4",Price=400,Stock=200},
            };
            }

            public int Hesapla() { return 100; }
        }

        class DataAccessLayerCips : IDataAccessLayer
        {
            public List<Product> GetProducts()
            {   // DB2
                return new List<Product>
            {
                new Product{Id=1,Name="CİPS1",Price=100,Stock=200},
                new Product{Id=2,Name="CİPS2",Price=200,Stock=200},
                new Product{Id=3,Name="CİPS3",Price=300,Stock=200},
                new Product{Id=4,Name="CİPS4",Price=400,Stock=200},
            };
            }
            public int Hesapla() { return 100; }
        }

        class Product
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
        }
    }
}
