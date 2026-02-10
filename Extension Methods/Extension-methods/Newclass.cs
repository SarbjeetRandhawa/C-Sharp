using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Extension_methods
{
    static class Newclass
    {
        public static void display2(this Oldclass o)
        {
            Console.WriteLine(o.a);
        }
        public static void display3(this Oldclass o, int a)
        {
            Console.WriteLine(a);
        }
    }

    class Program
    {
        public static void Main()
        {
            Oldclass o = new();
            o.display1();
            o.display2();
            o.display3(1000);
        }

    }
}

