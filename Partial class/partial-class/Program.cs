using System;
namespace PartialClass1
{
    partial class  Partialclass1
    {
        public string Name { get; set; }
        public int salary { get; set; }


    }
    public class Program
    {
        public static void Main()
        {
            Partialclass1 p = new()
            {
                Name = "Sarb",
                salary = 1000
            };

            p.display();
        }
    }
}