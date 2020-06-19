using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    abstract class Cars

    {
        private int _price;
        private int _copies;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Copies
        {
            get { return _copies; }
            set { _copies = value; }
        }

        public abstract void Display();
    }
}
