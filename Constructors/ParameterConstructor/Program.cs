using System;
namespace constructor
{
    class ParaConstructor
    {
        private int a;
        private int b;

        public ParaConstructor(int i , int j)
        {
            this.a = i;
            this.b = j;
        }
        public void display()
        {
            Console.WriteLine($"{a} , {b}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            ParaConstructor p = new(20, 40);
            p.display();
        }
    }
}