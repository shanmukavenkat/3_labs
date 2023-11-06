using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum:"+(a+b));
            Console.WriteLine("sub:"+(a-b));
            Console.WriteLine("mul:" + (a * b));
            Console.WriteLine("div:" + (a / b));
        }
    }
}
