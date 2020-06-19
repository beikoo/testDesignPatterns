using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    class Audi : Cars
    {
        private string _brand;
        private string _model;

        public Audi(string brand, string model, int price, int copies)
        {
            this._brand = brand;
            this._model = model;
            this.Price = price;
            this.Copies = copies;
        }

        public override void Display()
        {
            Console.WriteLine("\nCar ------ ");
            Console.WriteLine(" Brand: {0}", _brand);
            Console.WriteLine(" Model: {0}", _model);
            Console.WriteLine($" Price: {Price:c}");
            Console.WriteLine("#Cars left: {0}", Copies);
        }
    }
}
