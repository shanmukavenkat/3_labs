using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment8
{
    internal class Program
    {
        public Car()
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();  
            Console.WriteLine(Ford.model);  
        }

    }

}
