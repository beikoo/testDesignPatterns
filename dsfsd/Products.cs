using System;
using System.Collections.Generic;
using System.Text;

namespace dsfsd
{
    class ProductA1 : AbstractProductA

    {
    }

    class ProductB1 : AbstractProductB

    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {
    }

    class ProductB2 : AbstractProductB

    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
