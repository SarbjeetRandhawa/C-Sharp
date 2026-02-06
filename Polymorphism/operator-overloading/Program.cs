using System;
namespace Operator {

    class Complex{
        private int real ;
        private int img;

        public Complex(int r = 0, int i = 0) {
            this.real = r;
            this.img = i;
        }

        public static Complex operator +(Complex c1 , Complex c2)
        {
            Complex temp = new();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;


        }
        public void Display()
        {
            Console.WriteLine($"{real} , {img}i");
        }


    }
    class Program
    {
        public static void Main()
        {
            Complex c1 = new(3, 7);

            Complex c2 = new(3, 7);

            Complex c3 = c1 + c2;
            c1.Display();
            c2.Display();

            c3.Display();
        }
    }
 }