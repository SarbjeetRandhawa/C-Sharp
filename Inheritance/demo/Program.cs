using System;
namespace demo
{ 
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Animal");
        }
    }
    class Dog: Animal
    {
       
        public override void  speak()
        {
            Console.WriteLine("Dog");

        }
        
    }
    class Program
    {
        public static void Main()
        {
            //Dog d = new Dog();
            //d.speak();
            Dog animal = new Dog();
            animal.speak();
            ((Animal)animal).speak();

        }
    }
}