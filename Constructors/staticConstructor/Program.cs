using System;
using System.Data.SqlTypes;
namespace Constructor
{
    class Construct
    {
        static Construct()
        {
            Console.WriteLine($"Write your implementation here that you want to execute once");
        }

       
    }
    class Program
    {

        public static void Main()
        {
            Construct c = new();
            Console.WriteLine("Main method");
        }
    }
}