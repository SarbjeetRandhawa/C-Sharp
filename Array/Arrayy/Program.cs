using System;
namespace Arr
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[10];

            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10;
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int[] arr2 =  { 10, 70, 20, 55, 22 };

            foreach (int i in arr2)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            Array.Sort(arr2);
            foreach (int i in arr2)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            Array.Reverse(arr2);
            foreach (int i in arr2)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            Array.Copy(arr2, arr, 3);
            foreach (int i in arr2)
            {
                Console.Write(i + " ");

            }

        }
    }
}