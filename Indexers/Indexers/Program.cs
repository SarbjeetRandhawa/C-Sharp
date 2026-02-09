using System;
namespace Indexers
{
    class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Salary { get; set; }
        private string Location { get; set; }

        public Employee(int id, string name, int salary, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Location = location;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Id;
                }else if(index == 1)
                {
                    return Name;
                }else if(index == 2)
                {
                    return Salary;

                }else if(index == 3)
                {
                    return Location;
                }
                else
                {
                    return null;
                }

            }
            set
            {
                switch (index)
                {
                    case 0:
                        
                        Id = Convert.ToInt32(value);
                        break;
                    case 1:
                        Name = value?.ToString();
                        break;
                    case 2:
                        Salary = Convert.ToInt32(value);
                        break;
                    case 3:
                        Location = value?.ToString();
                        break;
                    default:
                        throw new IndexOutOfRangeException($"Invalid index: {index}");
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Employee e = new(101, "Sarbjeet", 1000000, "Jammu");

            Console.WriteLine(e[0]);
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);
            Console.WriteLine(e[3]);

            e[2] = 200000;
            e[3] = "Ahmedabaad";
            Console.WriteLine();

            Console.WriteLine(e[0]);
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);
            Console.WriteLine(e[3]);

        }
    }
}