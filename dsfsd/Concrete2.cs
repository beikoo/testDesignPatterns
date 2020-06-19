using DoFactory.GangOfFour.Abstract.Structural;
using System;
using System.Collections.Generic;
using System.Text;

namespace dsfsd
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
