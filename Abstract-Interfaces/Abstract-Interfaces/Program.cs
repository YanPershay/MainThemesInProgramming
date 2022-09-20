using System;

namespace Abstract_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method implemented in the IInterface
            // We have implementation in the interface and no implementation in the class:
            //         will be used implementation from the IInterface

            // We have implementation in the interface and new implementation in the class:
            //         will be used implementation from the RegularClass

            // RegularClass obj = new RegularClass(); --COMPILATION ERROR--
            IInterface obj = new RegularClass();
            obj.ImplementedMethod();
            #endregion

            Console.WriteLine("---------------------");

            // ImplementedInInterfaceSecondMethod() successfully executed
            // RegularClass obj2 = new RegularClass(); --COMPILATION ERROR--
            // ISecondInterface obj2 = new RegularClass(); --SUCCESS--
            IInterface obj2 = new RegularClass();
            obj2.ImplementedInInterfaceSecondMethod();

            Console.WriteLine("---------------------");

            AbstractClass obj3 = new RegularClass();
            obj3.AbstractMethod();
            obj3.VirtualMethod();
            AbstractClass.StaticMethod();

            Console.WriteLine("---------------------");

            RegularClass obj4 = new RegularClass();
            obj4.AbstractMethod();
            obj4.VirtualMethod();
            obj4.SecondMethod();
        }
    }
}
