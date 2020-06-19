using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory
{
    class GermanCarFactory : BrandFactory

    {
        public override BMW CreateBMW()
        {
            return new BMW316();
        }
        public override AUDI CreateAudi()
        {
            return new AudiA3();
        }
    }
}
