using System;
namespace Gc
{
    public class Generic<T>
    {
       public T a;
        public T b;

        public Generic(T a , T b)
        {
            this.a = a;
            this.b = b;
        }
       public T Add()
        {
            if(typeof(T) == typeof(int))
            {
                int result = (int)(object)a + (int)(object)b;
                return (T)(object)result;
            }
            if (typeof(T) == typeof(string))
            {
                string result = (string)(object)a + " " + (string)(object)b;
                return (T)(object)result;
            }
            throw new InvalidOperationException("error");
        }

    }
    class Program
    {
        public static void Main()
        {
            var intobj = new Generic<int>(10, 20);
            var stringobj = new Generic<string>("hello", "Sarbjeet");
            Console.WriteLine($"{intobj.Add()} , {stringobj.Add()}");

        }
    }
}