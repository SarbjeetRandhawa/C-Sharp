using System;
namespace Sealedd
{
    class Employee
    {
        protected int Eid;
        protected string Edesignation;

        public Employee(int i , string designation)
        {
            this.Eid = i;
            this.Edesignation = designation;
        }

        public virtual void display()
        {
            Console.WriteLine($"{Eid},{Edesignation} Employee");
        }



    }
     sealed class  Staff : Employee

    {
        public Staff(int i, string designation) : base(i, designation) { }
        public override void display()
        {
            base.display();
            Console.WriteLine($"{Eid},{Edesignation} Staff");
        }
    }
    class Program
    {
        
        public static void Main()
        {
            Staff s = new(10, "Developer");
            s.display();

        }
    }
}
