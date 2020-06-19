using Decorator.Decorator;
using System;
using System.Collections.Generic;

namespace Decorator
{
    class MainApp
    {
        static void Main()
        {

            Audi audi1 = new Audi("Audi", "A3", 10000,700000);
            audi1.Display();

            BMW bmw = new BMW("BMW", "I8", 5000, 100000);
            bmw.Display();

            Console.WriteLine("\nSelling two BMW Cars:");

            Customer customer = new Customer(audi1);
            customer.SellItem("Zdravko");
            customer.SellItem("Petur");

            customer.Display();
            Console.ReadKey();
        }
    }
}
