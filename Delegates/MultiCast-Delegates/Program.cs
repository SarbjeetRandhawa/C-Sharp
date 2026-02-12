using System;
namespace delegatess
{
    public delegate void d1(string s);
    public class Program
    {
        public static void Main()
        {
            d1 d = msg1;
            d += msg2;
            d("this was the message");
        }
        public static void msg1(string s)
        {
            Console.WriteLine($"Message is {s}");
        }
        public static void msg2(string s)
        {
            Console.WriteLine($"Message in UpperCase {s.ToUpper()}");
        }
    }
    
}