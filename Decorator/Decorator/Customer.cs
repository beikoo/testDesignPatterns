using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    class Customer : Decorator
    {
        protected List<string> customers = new List<string>();

        public Customer(Cars cars)
          : base(cars)
        {
        }

        public void SellItem(string name)
        {
            customers.Add(name);
            cars.Copies--;
        }

        public void ReturnItem(string name)
        {
            customers.Remove(name);
            cars.Copies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string customer in customers)
            {
                Console.WriteLine(" Customer: " + customer);
            }
        }
    }
}
