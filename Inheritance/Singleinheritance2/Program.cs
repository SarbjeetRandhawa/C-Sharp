using System;
using System.Buffers.Text;
namespace singleinheritance2
{
    class Animal
    {
        public int a = 5;
       
        public  void Speak()
        {

            
            Console.WriteLine(a);
        }
    }

    class Dog: Animal
    {
       
        public new void Speak()
        {
            base.Speak();
            a = 10;
            Console.WriteLine(a);
        }
    }
    class Program
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Speak();
        }
    }
}

