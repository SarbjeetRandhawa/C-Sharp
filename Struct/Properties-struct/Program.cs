using System;
namespace Struct{
    struct Employee
    {
        private int a;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Employee emp = new();
            emp.A = 10;

            Console.WriteLine(emp.A);

        }
    }
}