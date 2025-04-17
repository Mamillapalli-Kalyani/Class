using System;
abstract class Test
{
    public abstract void Display();//abstract method
    public void Add()//instance method
    {
        Console.WriteLine("hai");
    }
    public static void Show()//static method
    {
        Console.WriteLine("hello");
    }
    class Test1:Test
    {
        public override void Display()
        {
            Console.WriteLine("Good afternoon");
        }
    }
    static void Main(String[] args)
    {
        Test1 t1=new Test1();
        t1.Display();
        t1.Add();
        Show();
    }

}