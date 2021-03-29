using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Experiments
{
    class Program
    {

        //public int A { get; set; }

        public int get_AA()
        {
            return 0;
        }

        static int count { get; set; }
        static readonly object key = new object();

        static void Main(string[] args)
        {
            //string code;
            //int n1 = 0, n2 = 0;
            //code = Console.ReadLine();
            //var arr = code.ToCharArray();
            //foreach (var str in code)
            //{
            //    if (str.Equals('('))
            //        n1++;
            //    if (str.Equals(')'))
            //        n2++;
            //}
            //string res = n1 == n2 ? "Nice code" : "Incorrect brakes";
            //Console.WriteLine(res);

            //IINterface i = new Class();
            //Console.WriteLine(i.IMethod());

            //int x = 10;
            //DoubleX(x);//20
            //Console.WriteLine( DoubleX(x));//20
            //Console.WriteLine(x);//10
            //Console.WriteLine("----------------");
            //int y;
            //DoubleRef(x, out y);//y=20
            //Console.WriteLine(DoubleRef(y, out y));//y=40
            //Console.WriteLine(y);//40
            //Console.WriteLine("--------------");
            //Console.WriteLine(Ref(ref x));//20
            //Console.WriteLine(x);//20, not 10

            //for (int i = 1; i <= 2; i++)
            //{
            //    var thread = new Thread(ThreadMethod);
            //    thread.Start(i);
            //    Thread.Sleep(500);
            //}

            //var o = 1; o += 2;
            //dynamic o1 = 1; o1 += 2; o1 = "DDD";

            //Func(num);
            //Func(num);

            //A a = new A();
            //A b = new B();
            //A c = new C();
            ////
            //a.P();//A
            //b.P();//B
            //c.P();//B

            //Base b = new Base();
            //Class c = new Class();
            //Del d = new Del();
            //Console.WriteLine(b is Del);//false
            //Console.WriteLine(b is Class);//false
            //Console.WriteLine(b.GetType() == typeof(Class));//false
            //Console.WriteLine(c is Base);//true
            //Console.WriteLine(d is Base);//true

            //Den den = new Den();
            //den.Test();

            //int[] s0 = { 3, 2, 1, 6, 5, 4 };
            //var s1 = s0.Where(x => x % 2 == 0).OrderBy(x => x);
            //Print(s1);
            //s0[3] = 0;
            //Print(s1);//246||024

            //var cars = new List<string> { "Audi", "BMW", "Nissan", "Ford" };
            //var query = cars.Where(c => c.Length == 3);
            //cars.Remove("BMW");
            //Console.WriteLine(query.Count());//0

            //for(int i = 1000; i < 10000; i++)
            //{
            //    Console.Beep(i, 10000);
            //}

            //try
            //{
            //    string dir = @"C:\non";
            //    Directory.SetCurrentDirectory(dir);
            //}
            //catch(DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("DirectoryNotFound");//here
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("IOException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception");
            //}

            //try
            //{
            //    int val = int.Parse("exc");//exc
            //}
            //catch(Exception ex)
            //{
            //    throw;
            //}

            //Thread odd = new Thread(Odd);
            //Thread even = new Thread(Even);
            //
            //odd.Start();
            //Thread.Sleep(100);
            //
            //even.Start();
            //Thread.Sleep(100);//13579246810

            //Gen gen1 = new Gen();
            //Gen gen2 = new Gen();
            //gen1.x = 1200;
            //gen2.x = 0;
            //Chng(gen1, gen2);
            //Console.WriteLine(gen1.x);//

            //C3 c3 = new C3();
            //c3.Print(new C1());


        }

        public class C1
        {

        }

        public class C2 : C1
        {

        }

        public class C3
        {
            public void Print(C1 c1)
            {
                Console.WriteLine(c1.ToString());
            }
        }

        static void Chng(Gen gen1, Gen gen2)
        {
            gen2 = gen1;
        }

        static object monitor = new object();
        static void Odd()
        {
            lock (monitor)
            {
                for (int i = 1; i <= 10; i += 2)
                {
                    Console.Write(i);
                }
            }
        }

        static void Even()
        {
            lock (monitor)
            {
                for (int i = 0; i <= 10; i += 2)
                {
                    Console.Write(i);
                }
            }
        }

        static void Print(IEnumerable<int> integers)
        {
            foreach(var integer in integers)
            {
                Console.Write(integer);
            }
            Console.Write("||");
        } 

        public class Gen
        {
            public int x;
            public void Test()
            {
                
            }
        }

        public class Den : Gen
        {
        }

        interface IBase { }
        class Base : IBase { }
        class Class : Base { }
        class Del : Class { }

        class A
        {
            public virtual void P()
            {
                Console.WriteLine("A");
            }

            //public A()
            //{
            //    Console.WriteLine("A");
            //}
        }

        class B : A
        {
            //public B()
            //{
            //    Console.WriteLine("B");
            //}
            public override void P()
            {
                Console.WriteLine("B");
            }
        }

        class C : B
        {
            public new void P()
            {
                Console.WriteLine("C");
            }
        }

        static int num = 0;
        public static void Func(int num)
        {
            num++;
            Console.WriteLine(num);
        }

        struct Struct
        {
            //int x = 10;
        }

        static void ThreadMethod(object threadNumber)
        {
            while (true)
            {
                lock (key)
                {
                    var temp = count;
                    System.Console.WriteLine("Thread " + threadNumber + ": Reading the value of count.");
                    Thread.Sleep(1000);
                    count = temp + 1;
                    System.Console.WriteLine("Thread " + threadNumber + ": Incrementing the value of count to:" + count);
                }
                Thread.Sleep(1000);
            }
        }

        public static int Ref(ref int x)
        {
            return x * 2;
        }

        public static int DoubleRef(int x, out int y)
        {
            y = x * 2;
            return y;
        }

        public static int DoubleX(int x)
        {
            return x * 2;
        }
    }

    class StaticClass : A
    {
        //public static virtual void Met()
        //{

        //}
        public virtual void MetNonSTat()
        {

        }
    }

    class A
    {
        public void A1()
        {
            A2();
        }

        private void A2()
        {

        }
    }

    class B : A
    {
        public void Test()
        {
            A1();
        }
    }
    class Class : StaticClass, IINterface
    {
        int i = IINterface.Prop;
        public void Test()
        {
            MetNonSTat();
            //Met();
        }

        public int Prop { get; set; }

        public int IMethod()
        {
            return 20;
        }
    }

    abstract class AbstractClass
    {
        public int Method()
        {
            return 20;
        }
        public abstract int AbstrMeth();
    }

    interface IINterface
    {
        static int Prop { get; set; }

        int IMethod()
        {
            return 200;
        }
    }
}
