using System;
namespace Injection
{
    public interface Iengine
    {
        public void start();
    }

    public class Petrolengine : Iengine
    {
        public void start()
        {
            Console.WriteLine("Petrol Engine Started");
        }
    }

    public class Car
    {
        Iengine engine;
        public Car(Iengine e)
        {
            this.engine = e;
        }
        public void drive()
        {
            engine.start();
            Console.WriteLine("Car is Driving");
        }
    }
    class Program
    {
        public static void Main()
        {
            Iengine engine = new Petrolengine();
            Car c = new(engine);
            c.drive();

        }
    }
}