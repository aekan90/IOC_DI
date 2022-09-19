using System;
using System.Collections.Generic;
using System.Text;

namespace IOC_DI.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Atıf Ertuğrul KAN - Bilişim Uzmanı");
            Console.WriteLine("Nüfus ve Vatandaşlık İşleri Genel Müdürlüğü");
            Console.WriteLine("-------------------------------------------");


            BL bl = new BL();
            bl.GetProductsOnBL().ForEach(x => { Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}"); });
            Console.ReadLine();

        }
    }
}
