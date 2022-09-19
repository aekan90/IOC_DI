using System;
using System.Collections.Generic;
using System.Text;

namespace IOC_DI.ConsoleApp
{

    // Product classındaki datayı Product->DAL->BL->Program.cs
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
