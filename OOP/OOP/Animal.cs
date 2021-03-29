using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Animal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
