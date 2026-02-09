using System;
namespace PartialClass
{
    partial class  Partialclass
    {
        public string Name { get; set; }
        public int salary { get; set; }


    }
    public class Program
    {
        public static void Main()
        {
            Partialclass p = new()
            {
                Name = "Sarb",
                salary = 1000
            };

            p.display();
        }
    }
}