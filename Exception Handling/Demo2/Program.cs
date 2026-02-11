using System;
namespace Demo2
{
    class Program
    {
        public static void Main()
        {
            int i, j, k;

            try
            {
                i = int.Parse(Console.ReadLine());
                j = int.Parse(Console.ReadLine());
                k = i / j;
                Console.WriteLine(k);


            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine($"Please dont divide by Zero , {d.Message}");
            }
            catch (FormatException f)
            {
                Console.WriteLine($"Please dont enter string value , {f.Message}");
            }
            
        }
    }
}