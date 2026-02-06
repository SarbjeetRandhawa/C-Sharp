using System;
namespace polymorphism
{
    class Calculator
    {
        public void Add(int a , int b)
        {
            Console.WriteLine( a + b);
        }
           public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a , int b , int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Add(string a , string b)
        {
            Console.WriteLine(a+ " "+ b);
        }
    }
    class Program
    {
        public static void Main()
        {
            Calculator c = new();
            c.Add(2, 4);
            c.Add(5, 5, 5);
            c.Add(2.4f, 2.4f);
            c.Add("hello", "morning");

        }
    }
}