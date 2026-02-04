using System;
namespace hierarchical
{
    class Animal
    {
        public  virtual void speak()
        {
            Console.WriteLine("animal");
        }
    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Dog");
        }
    }
    class Cat : Animal
    {
        public new void speak()
        {
            
            Console.WriteLine("cat");
        }
    }

    class Program
    {
        public static void Main()
        {
            Dog d = new Dog();
            Cat c = new Cat();
            d.speak();
            c.speak();
        }
    }

}