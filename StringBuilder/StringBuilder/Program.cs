using System;
using System.Text;
namespace Stringbuilder
{
    class Program
    {
        public static void Main()
        {
            StringBuilder s = new(25);
            s.Append("hello , good morning ");
            Console.WriteLine(s);
            s.AppendFormat("{0:C}", 60);
            Console.WriteLine(s);
            s.Insert(6, "g");
            Console.WriteLine(s);
            s.Remove(8, 5);
            Console.WriteLine(s);
            s.Replace("hello", "hy");
            Console.WriteLine(s);


        }
    }
}