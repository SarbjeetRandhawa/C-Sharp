using System;
namespace multiple2
{
    public interface Car
    {
        void test();
    }
    public interface Bike
    {
        void test();
    }
    class Vehicle : Car, Bike
    {
        void Car.test()
        {
            Console.WriteLine("this is car");
        }

        void Bike.test()
        {
            Console.WriteLine("this is bike");
        }

    }
    class Program
    {
        public static void Main()
        {
            Vehicle v = new Vehicle();

            ((Car)v).test();
            ((Bike)v).test();
        }
    }
}