using System;
namespace Exceptions
{
    public class Program
    {
        public static void Main()
        {
            int a = 10;
            int b = 0;
            int c;
            try
            {
                c = a / b;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine($"2. {e.Source}");
                Console.WriteLine($"3. {e.HelpLink}");

                Console.WriteLine($"4. {e.StackTrace}");
            }
        }
    }
}