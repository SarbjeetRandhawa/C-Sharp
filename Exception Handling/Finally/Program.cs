using System;
namespace Finallyy
{
    class Program
    {
        public static void Something()
        {
            try
            {
                Console.WriteLine("inside try block");
                int i = 10, j = 0;
                int c = i / j;
            }
            finally
            {
                Console.WriteLine("inside Finally block");
            }
        }
        public static void Main()
        {
            try
            {
                Something();
            }catch(Exception c)
            {
                Console.WriteLine($"Exception caught , {c.Message}");
            }
        }
    }
}