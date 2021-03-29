using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Lock baseLock = new BaseLock();

            Lock electricLock = new ElectricLock();

            baseLock.Open();

            electricLock.Open();

            Cat cat = new Cat();
            cat.AnimalSound();
            cat.Sleep();
        }
    }
}
