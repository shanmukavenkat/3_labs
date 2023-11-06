using System;
namespace method_overload
{
    class Program
    {
        void add(int a, int b)
        {
            Console.WriteLine(a + b );
        }
        void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }


        public static void Main(String[] args)
        {
            Program p1 = new Program();
            p1.add(45, 67);
            p1.add(12, 34, 56);
        }
    }
}
