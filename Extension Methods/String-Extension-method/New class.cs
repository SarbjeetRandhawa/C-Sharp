using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extension_method
{
    public static class StringHelper
    {
        public static void Display(this string s)
        {
            Console.WriteLine($"[string extension] : {s.ToUpper()}");
        }
        public static void Display2(string s)
        {
            Console.WriteLine($"[static Method] : {s.ToLower()}");
        }
    }
}
