using System;
namespace ConstructorChaining
{
    public class Employee
    {
        private int id;
        private string name;

        public Employee(int id)
        {
            this.id = id;
        }

        public Employee(int id ,string name) : this(id)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"{id} , {name}");
        }
    }

    class Program
    {
        public static void Main()
        {
            Employee e = new(10, "Sarbjeet");
            e.display();
        }
    }
}