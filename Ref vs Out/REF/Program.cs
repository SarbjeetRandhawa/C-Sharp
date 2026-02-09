using System;
namespace Ref
{
    class Program
    {
        public static void Main()
        {
            int amount = 100;

            int sub = 0;

             add(100, 200, ref amount , ref sub);
            Console.WriteLine($"addition is {amount} and subtraction is {sub}");
        }
        public static void add(int a , int b , ref int amount , ref int sub)
        {
            sub = b - a;
            amount += a + b;
        }
    }
}
// READ AND WRITE ONLY