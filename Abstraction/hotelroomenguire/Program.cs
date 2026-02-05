using System;
namespace abstraction { 
    public interface IRoom
    {
         Decimal Rate { get; }
         int Capacity { get; }

        public void Display();
    }
    public class Standard : IRoom
    {
        public Decimal Rate => 100;
        public int Capacity => 2;
        public void Display()
        {
            Console.WriteLine($"Standard room price is {Rate:C} , and capacity is  {Capacity}");
        }
    }

    public class Delux : IRoom
    {
        public Decimal Rate => 4000;
        public int Capacity => 8;

        public void Display()
        {
            Console.WriteLine($"Delux room  price is {Rate:C} and capacity is {Capacity}");
        }
    }

    public class Manager
    {
        public void Booking(IRoom room)
        {
            room.Display();
            Console.WriteLine("Room Booked");
        }
    }

    class Program
    {
        public static void Main()
        {
            IRoom standard = new Standard();
            IRoom delux = new Delux();

            Manager m = new();

            m.Booking(standard);
            m.Booking(delux);
        }
    }
}