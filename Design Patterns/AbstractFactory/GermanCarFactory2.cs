using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    class GermanCarFactory2 : BrandFactory

    {
        public override BMW CreateBMW()
        {
            return new i8();
        }
        public override AUDI CreateAudi()
        {
            return new A8L();
        }
    }
}
