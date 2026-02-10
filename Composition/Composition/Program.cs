using System;
namespace Compositionn
{
    class Empoyee
    {
        public int a;
        public int b;

        public Empoyee(int a = 10, int b= 20)
        {
            this.a = a;
            this.b = b;
        }
        public void add()
        {
            Console.WriteLine($"Employee  {a+b}" );

        }

    } 
    class Manager
    {
        Empoyee _employee = new();
        public void display()
        {
            _employee.add();
            Console.WriteLine("Manager");
        }

    }

    class Program
    {
        public static void Main()
        {
            Manager M = new();
            M.display();
        }
    }
}