using System;

namespace Abstract_Interfaces
{
    public interface ISecondInterface // : IInterface --IMPOSSIBLE--
    {
        void ImplementedInInterfaceSecondMethod()
        {
            Console.WriteLine("Implemented ImplementedInInterfaceSecondMethod() in ISecondInterface");
        }

        void SecondMethod();
    }
}
