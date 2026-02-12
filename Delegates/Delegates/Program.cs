using System;
using System.Reflection;
namespace delegatess
{
    public delegate void first(string name);

    class Program
    {
        public static void Main()
        {
            Handler h = new();
            first f = h.GetName;
            Display(f);
            
        }
        public static void Display(first d1) {
            d1("arisu");
        }

        public class Handler
        {
            public void GetName(string name)
            {
                Console.WriteLine(name);
            }
        }
    }
}




