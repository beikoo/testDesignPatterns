using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    class i8 : BMW
    {

    }

    class A8L : AUDI
    {
        public override void Beat(BMW h)
        {
            // faster then i8

            Console.WriteLine(this.GetType().Name +
              " faster then " + h.GetType().Name);
        }
    }
}
