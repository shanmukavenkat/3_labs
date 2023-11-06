using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_namespace
{
    namespace A
    {
        namespace B
        {
            public class CSM
            {
                public void display()
                {
                    Console.WriteLine("nested namespace");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A.B.CSM h1 = new A.B.CSM();
            h1.display();
        }
    }
}
