using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("enter a number");
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                sum=sum+i;
            }
            Console.WriteLine(sum);
        }
    }
}
