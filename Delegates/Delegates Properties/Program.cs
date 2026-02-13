using System;
using System.Reflection;
namespace Delegatess1
{
    public delegate void d1(string s);

    class Program
    {
        public static void Main()
        {
            Handler h = new();
            d1 d = h.DosomeWork;

            MethodInfo method = d.Method;
            object target = d.Target;
            Delegate[] logs = d.GetInvocationList();


            Console.WriteLine($"{ method} , { target}");
            foreach(var i in logs)
            {

                Console.Write(i + " ");
            }
        }
    }
    public class Handler
    {
        public void DosomeWork(string s)
        {
            Console.WriteLine("Handler method executed");
            Console.WriteLine($"{s}");
        }
    }
}