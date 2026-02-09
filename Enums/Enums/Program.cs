using System;
using System.Runtime.InteropServices.Marshalling;
namespace Enums
{

    public class Employee
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

    public enum Gender
    {
        unknown,
            male,
            female
    }

    class Program
    {
        public static void Main()
        {
            List<Employee> Emp = new List<Employee>
            {
                new Employee(){Name = "harsh" , Gender = 0 },
                new Employee(){Name = "sarb" , Gender = 1 },
                new Employee(){Name = "karan" , Gender = 2 },



            };
            foreach(var emp in Emp)
            {
                Console.WriteLine($"naem is {emp.Name} ,Gender is {GetGender(emp.Gender)}  ");
            }
        }
        public static string GetGender(int a)
        {
            switch (a)
            {
                case (int)Gender.unknown:
                    return "unknown";
                case (int)Gender.male:
                    return "Male";
                case (int)Gender.female:
                    return "Female";
                default:
                    return "invalid data";
            }
        }
        
    }
}