using System;
namespace Constructor
{
    class Construct
    {
        private int x;
        private int y = 20;

        public Construct(int a)
        {
            this.x = a;
        }
        public Construct(Construct obj)
        {
            this.x = obj.x;
            this.y += obj.x;
        }
        public void display()
        {
            Console.WriteLine($"{x}, {y}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Construct ob1 = new(10);
            ob1.display();

           Construct ob2 = new(ob1);

          
            ob2.display();
        }
    }
}