using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    abstract class BMW

    {
    }

    abstract class AUDI

    {
        public abstract void Beat(BMW h);
    }

    class BMW316 : BMW
    {
    }

    class AudiA3 : AUDI

    {
        public override void Beat(BMW h)
        {
            //a3 faster then 316
            Console.WriteLine(this.GetType().Name +
              " faster then " + h.GetType().Name);
        }
    }
}
