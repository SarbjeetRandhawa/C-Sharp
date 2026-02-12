using System;
namespace delegatess
{
    public class Program
    {
        public static void Main()
        {
            Action<string> a = name => Console.WriteLine($"name is {name}");
            a("Sarbjeet");

            Func<int, int, int, int> add = ( b, c,d) =>  b + c + d;
            int result = add(10, 20, 20);
            Console.WriteLine(result);

            Predicate<int> iseven = num => num % 2 == 0;
            bool result1 = iseven(5);
            Console.WriteLine(result1);

        }
    }
}