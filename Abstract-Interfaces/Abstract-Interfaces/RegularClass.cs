using System;

namespace Abstract_Interfaces
{
    public class RegularClass : AbstractClass, IInterface
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Overrided AbstractMethod() in RegularClass");
        }

        public void FirstMethod()
        {
            Console.WriteLine("Implemented FirstMethod() in RegularClass");
        }

        public void SecondMethod() // need to be implemented in case of "IInterface : ISecondInterface"
        {
            Console.WriteLine("Implemented SecondMethod() in RegularClass");
        }

        //public void ImplementedMethod() // will be executed
        //{
        //    Console.WriteLine("ImplementedMethod() implementation in RegularClass.");
        //}
    }
}
