using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    class BMW : Cars
    {
        private string _bmwbrand;
        private string _bmwmodel;

        public BMW(string brand, string model,
          int copies, int price)
        {
            this._bmwbrand = brand;
            this._bmwmodel = model;
            this.Copies = copies;
            this.Price = price;
        }

        public override void Display()
        {
            Console.WriteLine("\nCar ----- ");
            Console.WriteLine(" brand: {0}", _bmwbrand);
            Console.WriteLine(" model: {0}", _bmwmodel);
            Console.WriteLine("#Cars left: {0}", Copies);
            Console.WriteLine($" Price: {Price:c}");
        }
    }
}
