using System;

namespace Abstract_Interfaces
{
    public abstract class AbstractClass
    {
        private readonly string _justString = "Just String";

        public abstract void AbstractMethod();
        // IMPOSSIBLE:
        //{
        //    Console.WriteLine();
        //}

        public virtual void VirtualMethod() // must declare body
        {
            Console.WriteLine("VirtualMethod() from AbstractClass");
            PrivateMethod();
        }

        private void PrivateMethod()
        {
            Console.WriteLine("... and PrivateMethod() from AbstractClass");
        }

        //public abstract static void StaticMethod() // impossible: or static void or abstract void

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod() from AbstractClass"); // "shows you {_justString}");" impossible in static method
        }
    }
}
