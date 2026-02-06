using System;
namespace Destructors
{
    class Demo
    {
        public Demo()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Demo()
        {
            Console.WriteLine("Destructor invoked");
        }
    }
    class Program
    {
        public static void Main()
        {
            Demo? d = new();
            d = null;
            GC.Collect();
        }
    }
}