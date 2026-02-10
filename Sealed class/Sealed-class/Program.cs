using System;
namespace Sealedd
{
    class Emoployee
    {
        protected int Id;
        protected string name;

        public virtual void getData()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
        }
        public virtual void display()
        {
            Console.WriteLine($"{Id} , {name}");
            Console.WriteLine("Employee");
        }

    }
    class Manager : Emoployee
    {
        protected int age;
        public sealed override void getData()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public override void display()
        {
            Console.WriteLine($"{Id} , {name} , {age}");
            Console.WriteLine("Manager");


        }
    }
    class Staf : Manager
    {

        public override void display()
        {
            Console.WriteLine($"{Id} , {name} , {age}");
            Console.WriteLine("Staf");

        }
    }

    class Program
    {
        public static void Main()
        {
            Staf m = new();
            m.getData();
            m.display();

        }
    }
}
