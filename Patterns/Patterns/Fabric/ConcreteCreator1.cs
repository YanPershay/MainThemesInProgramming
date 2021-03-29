using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fabric
{
    class ConcreteCreator1 : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
