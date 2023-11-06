using System;
namespace method_overload_datatype
{
    class Program
    {
        int display(int a)
        {
            return a;
        }
        void display(String b)
        {
            Console.WriteLine(b);
        }

        


        public static void Main(String[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("Roll No:" + p1.display(45));
            p1.display("Sai Sri Harsha");
        }
    }
}
