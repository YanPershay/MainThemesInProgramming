using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fabric
{
    class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
