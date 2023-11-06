using System;
namespace method_overload_order
{
    class Program
    {
        void display(int a,String b)
        {
            Console.WriteLine("Roll No:" + a);
            Console.WriteLine("Name:"+b);
        }
        void display(String b,int a)
        {
            Console.WriteLine("Name:" + b);
            Console.WriteLine("Roll No:" + a);
            
        }
        




        public static void Main(String[] args)
        {
            Program p1 = new Program();
            
            p1.display(45,"Sai Sri Harsha");
            p1.display("Sai Sri Harsha",45);
        }
    }
}
