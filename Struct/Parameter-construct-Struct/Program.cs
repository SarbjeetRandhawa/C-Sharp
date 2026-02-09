using System;
namespace Struct
{
    struct Employee
    {
        private int a;

        public Employee(int b)
        {
            a = b;
        }
        public void display()
        {
            Console.WriteLine($"value is {a}");
        }

    }
    class Program
    {
        public static void Main()
        {
            Employee emp = new(100);
            emp.display();
        }
    }
}