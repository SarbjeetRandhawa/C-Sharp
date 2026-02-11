using CustomException;
using System;
namespace Customexception
{
    class Program
    {
        public static void Main()
        {
            try
            {
                int a = 10, b = 2;
                int c = a / b;
                if(b % 2 != 0)
                {

                throw new oddNumberexception();
                }
            }catch(oddNumberexception o)
            {
                Console.WriteLine(o.Message);
            }
        }
    }
}