using System;
using System.Collections.Generic;
using System.Text;

namespace IOC_DI.ConsoleApp
{
    class DAL : IDAL
    {
        public List<Product> GetProducts()
        {   // SQL server
            return new List<Product>
            {
                new Product{Id=1,Name="Kalem1",Price=100,Stock=200},
                new Product{Id=2,Name="Kalem2",Price=200,Stock=200},
                new Product{Id=3,Name="Kalem3",Price=300,Stock=200},
                new Product{Id=4,Name="Kalem4",Price=400,Stock=200},
            };
        }

        public int Hesapla()
        {
            return 100;
        }



    }
}
