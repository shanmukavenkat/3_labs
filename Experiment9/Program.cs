using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        public static void ex1()
        {
            Console.WriteLine("child thread 1");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("child thread 1 excuting");
                Thread.Sleep(500);
            }
        }
        public static void ex2()
        {
            Console.WriteLine("child thread 2");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("child thread 2 excuting");
                Thread.Sleep(500);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread created");
            Thread t1 = new Thread(ex1);
            Thread t2 = new Thread(ex2);
            t1.Start();
            t2.Start();
        }
        



    }
}
