using System;
namespace Constructors
{
    class Defaultconst
    {
        public Defaultconst()
        {
            Console.WriteLine("this is default consructor");
        }
    }
    class Program
    {
        public static void Main()
        {
            Defaultconst d = new();
        }
    }
}