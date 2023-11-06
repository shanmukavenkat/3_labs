using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment10
{
    namespace First
    {
        public class Hello
        {
            public void sayHelllo()
            {
                Console.WriteLine("Hello First Namespace");

            }
        }
    }
    namespace Second
    {
        public class Hello
        {
            public void sayHelllo()
            {
                Console.WriteLine("Hello Second Namespace");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello hello1 = new First.Hello();
            Second.Hello hello2 = new Second.Hello();
            hello1.sayHelllo();
            hello2.sayHelllo();
        }
    }
}
