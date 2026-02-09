using System;
namespace Out
{
    class Program
    {
        public static void Main()
        {

            //int Add = 100;
            calculation(100, 100, out int  Add, out int sub, out int multi);
            Console.WriteLine($"Add is {Add} , sub is  {sub} , multi is {multi}");
        }
        public static void calculation(int a , int  b , out int Add , out int sub , out int multi)
        {
            Add  = a + b;
            sub = a - b;
            multi = a * b;
        }
    }
}
//WRITE ONLY