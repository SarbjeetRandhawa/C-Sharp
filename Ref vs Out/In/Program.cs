using System;
namespace In
{
    public class Program
    {
        public static void Main()
        {
            String Message2 = "this is printing using In keywords";

            Msg(in Message2);
        }
        public static void Msg(in string Message2)
        {
            Console.WriteLine(Message2);
        }
    }
}
// READ ONLY