using System;
namespace multilevel
{
    class Animal
    {
        public void speak()
        {
            Console.WriteLine("animal");
        }
    }
    class Dog : Animal
    {
        public new void speak()
        {
            base.speak();
            Console.WriteLine("dog");
        }
        public void bark()
        {
            Console.WriteLine("barking");
        }
    }

    class Puppy : Dog
    {
        public new void speak()
        {

            base.speak();

            Console.WriteLine("puppy");
        }

        public new void bark()
        {
            base.bark();
            Console.WriteLine("trying to bark");
        }
    }

    class Program
    {
        public static void Main()
        {
            Puppy p = new Puppy();
            
            p.speak();
            p.bark();
        }
        
    }
}