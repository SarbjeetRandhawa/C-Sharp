using System;
namespace runtime
{
    class Class1
    {
        public virtual void display()
        {
            Console.WriteLine("class 1 is showing");
        }

    }
    class Class2 : Class1
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("CLASS2 IS SHOWING");
        }
    }
    class Program
    {
        public static void Main()
        {
            Class1 c = new Class2();
            c.display();
        }
    }
}