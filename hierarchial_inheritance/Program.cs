using System;
public class veichle
{
    public string name;
    public string num;
    public void display()
    {
        Console.WriteLine("It is " + name + " Car with Car Number " + num);
    }

}
public class Hundai : veichle
{
    public Hundai(string name1, string num1)
    {
        name = name1;
        num = num1;
    }

}
public class Tesla : veichle
{
    public Tesla(string name4, string num4)
    {
        name = name4;
        num = num4;
    }


}
public class Ferrari : veichle
{
    public Ferrari(string name4, string num4)
    {
        name = name4;
        num = num4;
    }



}
public class MG : veichle
{

    public MG(string name4,string num4)
    {
        name = name4;
        num = num4;
    }


}
public class Program
{
    public static void Main(String[] args)
    {
        Tesla v1=new Tesla("Tesla", "2003");
        v1.display();
        Hundai v2 = new Hundai("Hundai", "1234");
        v2.display();
        Ferrari v3 = new Ferrari("Ferrari", "1322");
        v3.display();
        MG v4 = new MG("MG", "2005");
        v4.display();

    }
}