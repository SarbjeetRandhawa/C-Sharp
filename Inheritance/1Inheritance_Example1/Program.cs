using System;
using System.Diagnostics;
namespace inheritenceExacmple
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Diet { get; set; }

        public Animal (string name , int age, string diet)
        {
            Name = name;
            Age = age;
            Diet = diet;

        }
        public virtual void display()
        {
            Console.WriteLine($"name is {Name} , age is {Age} , and Diet is {Diet}");
        }
    }

    class Parrot : Animal
    {
       public bool Canfly { get; set; }

        public Parrot(string name,int age, string diet, bool canfly ) : base(name, age, diet)
        {
            Canfly = canfly;
        }

        public void fly()
        {
            if (Canfly)
            {
                Console.WriteLine("able to fly");
            }
            else
            {
                Console.WriteLine("unable to fly");
            }
        }
        public override void display()
        {
            base.display();
            fly();
        }
    }
    class Mammel     : Animal
    {
        public String Sound { get; set; }

        public Mammel(string name, int age, string diet, string sound) : base(name, age, diet)
        {
            Sound = sound;
        }

        public void SoundName()
        {
            Console.WriteLine($"the name of the sound is {Sound}");
        }
        public override void display()
        {
            base.display();
            SoundName();
        }
    }
    class Program
    {
        public static void Main()
        {
            Parrot p = new Parrot("mackao" ,5,"chilly" ,true);
            p.display();
            Mammel l = new Mammel("Lion", 5, "meat", "Roar");
            l.display();

        }
    }

}