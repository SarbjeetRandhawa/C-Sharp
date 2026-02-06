using System;
using System.ComponentModel;
namespace Practice
{
    public interface C {
        
        
        public void display()
        {
            Console.WriteLine("interface");
        }

    }
    public class A : C
    {
       public void display()
        {
            
            Console.WriteLine("child");
            //((C)this).display();
        }
    }
    class Program
    {
        public static void Main()
        {
            C a = new A();
            a.display();
        }
    }
}