using System;
namespace Partialclass
{
    partial class PartialC
    {
        public int a { get; set; }

        public partial void Display();
       public void Display2()
        {
            Console.WriteLine($"public one value is {a + 100}");
        }
    }
    class Program
    {
        public static void Main()
        {
            PartialC c = new()
            {
                a = 1000
            };
            c.Display2();
            c.Display();
           

        }
    }
}