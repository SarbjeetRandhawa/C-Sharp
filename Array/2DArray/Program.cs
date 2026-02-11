using System;
namespace Arr2D{
    class Program
    {
        public static void Main()
        {
            int[,] arr = new int[3, 3];

            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = (i + 1) + (j + 2);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}