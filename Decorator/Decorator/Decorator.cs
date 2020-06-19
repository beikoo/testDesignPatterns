using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    abstract class Decorator : Cars

    {
        protected Cars cars;

        public Decorator(Cars cars)
        {
            this.cars = cars;
        }

        public override void Display()
        {
            cars.Display();
        }
    }
}
