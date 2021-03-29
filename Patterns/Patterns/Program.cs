using Patterns.Adapter;
using Patterns.Fabric;
using Patterns.Strategy;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Adapter--------------");
            #region Adapter

            SpecificClass specific = new SpecificClass();
            ICommon common = new Adaptee(specific);

            Console.WriteLine(common.Method());

            #endregion

            Console.WriteLine("-----------Factory--------------");
            #region Factory

            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreator1();
            creators[1] = new ConcreteCreator2();

            foreach(Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            #endregion

            Console.WriteLine("-----------Strategy--------------");
            #region Strategy

            Context context = new Context(new ConcreteStrategy1());
            context.ExecuteOperation();

            context.SetStrategy(new ConcreteStrategy2());
            context.ExecuteOperation();

            #endregion

            Console.WriteLine("-----------Singleton--------------");
            #region Singleton

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if(singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works, there are same objects.");
                singleton1.DoLogic();
                singleton2.DoLogic();
            }
            else
            {
                Console.WriteLine("Singleton incorrect");
                singleton1.DoLogic();
                singleton2.DoLogic();
            }
            #endregion
        }
    }
}
