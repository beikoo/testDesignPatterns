using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    abstract class BrandFactory
    {
        public abstract AUDI CreateAudi();
        public abstract BMW CreateBMW();
    }
}
