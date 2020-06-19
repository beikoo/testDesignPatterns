using DoFactory.GangOfFour.Abstract.Structural;
using System;
using System.Collections.Generic;
using System.Text;

namespace dsfsd
{
    abstract class AbstractFactory

    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
