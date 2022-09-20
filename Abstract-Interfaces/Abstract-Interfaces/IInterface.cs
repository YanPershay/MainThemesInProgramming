using System;

namespace Abstract_Interfaces
{
    public interface IInterface : ISecondInterface
    {
        // possible but has no sense
        // private void PrivateMethod()
        // {
        //     Console.WriteLine("Implemented private method in the interface x_x");
        // }

        // possible but has no sense
        // static void StaticMethod() 
        // {
        //     Console.WriteLine("Implemented static method in the interface x_x");
        // }

        void ImplementedMethod()
        {
            Console.WriteLine("Default method implementation in the interface");
        }

        void FirstMethod();
    }
}
