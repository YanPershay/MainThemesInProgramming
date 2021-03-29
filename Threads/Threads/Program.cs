using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static object locker = new object();

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Numbers));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();

            Console.WriteLine("Main():");
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Thread mythread = new Thread(new ParameterizedThreadStart(Hundreds));
            mythread.Start(10);

            Thread thread2 = new Thread(new ThreadStart(OneByOne));
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(DoItInOrder));
            thread3.Start();
        }

        public static void OneByOne()
        {
            Thread.Sleep(1000);
            Console.WriteLine("OneByOne():");
            Mutex mutex = new Mutex();

            Thread thread1 = new Thread(new ThreadStart(Two));
            Thread thread2 = new Thread(new ThreadStart(One));
            thread1.Start();
            thread2.Start();

            void Two()
            {
                mutex.WaitOne();
                Console.WriteLine("         Divided 2():");
                for (int i = 1; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                mutex.ReleaseMutex();
            }

            void One()
            {
                mutex.WaitOne();
                Console.WriteLine("         Not Divided 2():");
                for (int i = 1; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                mutex.ReleaseMutex();
            }
        }

        public static void DoItInOrder()
        {
            Console.WriteLine("DoItInOrder():");
            Thread oddTh = new Thread(new ThreadStart(PrintOdd));
            Thread evenTh = new Thread(new ThreadStart(PrintEven));
            oddTh.Start();
            evenTh.Start();
            void PrintOdd()
            {
                Console.WriteLine("Not 2:");
                lock (locker)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

            void PrintEven()
            {
                Console.WriteLine("Yes 2:");
                lock (locker)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        public static void Numbers()
        {
            Console.WriteLine("Numbers():");
            lock (locker)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static void Hundreds(object max)
        {
            int k = (int)max;
            lock (locker)
            {
                Console.WriteLine("Hundreds():");
                for (int i = 1; i < k; i++)
                {
                    Console.WriteLine(i * 10);
                }
            }
        }
    }
}
