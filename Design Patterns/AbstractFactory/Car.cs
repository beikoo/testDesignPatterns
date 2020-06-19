using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    class Car
    {
        private BMW _bmw;
        private AUDI _audi;

        public Car(BrandFactory factory)
        {
            _audi = factory.CreateAudi();
            _bmw = factory.CreateBMW();
        }

        public void BeatChain()
        {
            _audi.Beat(_bmw);
        }
    }
}
