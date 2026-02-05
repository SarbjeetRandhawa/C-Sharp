using System;
namespace Encapsulation
{
    public class Car
    {
        private int wheelrotation;
        private double gearRatio = 4.2;
        private const int circumfrence = 2;

        public Car()
        {
            wheelrotation = 0;
        }

        private void move()
        {
            wheelrotation++;
        }

        private double  CalculateSpeed()
        {
            double distance = wheelrotation * circumfrence;
            double time = 1;
            double speed = (distance * gearRatio) / time;

            return speed;
            
        }

        public void Drive()
        {
            move();
            Console.WriteLine($"speed of the vehicle is {CalculateSpeed()} m/s");
        }
    }
    class Program
    {
        public static void Main()
        {
            Car c = new();

            c.Drive();
            c.Drive();
        }
    }
}