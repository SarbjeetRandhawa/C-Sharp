using System;
using System.Data.SqlTypes;
namespace Struct{

    public struct Employee
    {
        public int a;

        public void getId (int b)
        {
            Console.WriteLine(b);
        }
    };
    public class Program
    {
        public static void Main()
        {
            Employee emp;
            emp.a = 100;

            emp.getId(emp.a);
        }
    }


}