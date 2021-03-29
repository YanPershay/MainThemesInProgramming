using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void DoAlgorithm()
        {
            Console.WriteLine("Concrete algorithm 2");
        }
    }
}
