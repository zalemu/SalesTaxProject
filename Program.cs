using System;
using SalesTaxes.Shopping;

namespace SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************Program Started***************************");
            Store store = new Store();
            store.GetOrder();
            store.CheckOut();
            Console.WriteLine("***************************Program Terminated***************************");
            Console.ReadLine();
        }
    }
}
