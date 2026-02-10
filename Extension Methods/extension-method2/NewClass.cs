using System;
using System.Collections.Generic;
using System.Text;

namespace Extensionmethod
{
     static class NewClass
    {
        public static void display2(this OldClass o, int a)
        {
            Console.WriteLine("Newclass" + a);
        }
        public static void display1(this OldClass o)
        {
            Console.WriteLine("Newclass");
        }
    }
}
