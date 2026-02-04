using System;
namespace Singleinheritance
{
    class Rectangle
    {
        public int b;
        public int l;

        public int area()
        {
            return l * b;
        }
        public int perimeter()
        {
            return 2 * l + 2 * b;
        }
    }

    class cuboid : Rectangle
    {
        public int c;
        public cuboid(int l, int b, int c)
        {
            this.l = l;
            this.b = b;
            this.c = c;
        }
        public int voulume()
        {
            return l * b * c;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            cuboid cb = new cuboid(10, 20, 30);

            Console.WriteLine(cb.voulume());
            Console.WriteLine(cb.area());
            Console.WriteLine(cb.perimeter());
        }

    }
}