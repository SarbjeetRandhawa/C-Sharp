using System;
namespace Enums
{
    class Program
    {
        public static void Main()
        {
            string[] methodss = (string[])Enum.GetNames(typeof(Gender));

            foreach(var value in methodss)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            int[] valuee = (int[])Enum.GetValues(typeof(Gender));
            foreach (var value in valuee)
            {
                Console.WriteLine(value);
            }

        }
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }
}