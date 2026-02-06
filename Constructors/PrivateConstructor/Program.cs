using System;
namespace Privateconstructor
{
    class Program
    {
        private Program(){
            Console.WriteLine("private is working");
        } 

        public static void Main()
        {
            Program p = new();
        }
    }
}
