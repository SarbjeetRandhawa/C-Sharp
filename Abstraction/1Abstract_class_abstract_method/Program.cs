using System;
namespace Abstraction
{
    public abstract class Animal
    {
        public abstract void speak();
        public void sound(string sound)
        {
            Console.WriteLine($"sound is {sound}");
        }
       
    }
    public class Pig : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Animal is speaking");
        }
    }
    class Program
    {
        public static void Main()
        {
            Pig p = new();
            ((Animal)p).speak();
            p.sound("weee weee");

        }
    }
}