using System;
using System.Collections;
using System.Data.SqlTypes;

namespace arrlist
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arr = new ArrayList()
            {
                 "sarbjeet",
                 101,
                 " ",
                 true

            };
            arr.Add("bye bye");

            foreach(var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }

            arr.Insert(0, "first item"); 
            Console.WriteLine();

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            arr.RemoveAt(2);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            arr.Remove("first item");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            arr.RemoveRange(0, 1);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();



            ArrayList arr2 = (ArrayList)arr.Clone();
            foreach (var i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();




        }
    }
}