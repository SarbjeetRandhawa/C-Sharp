using System;
namespace Hybrid
{
    public interface A
    {
        void test();
    }

    public interface B : A
    {
        void test2();
    }
    public interface C : A
    {
        void test3();
    }
    public class  D : B, C
    {
        public void test()
        {
            Console.WriteLine("this is A");
        }
        void C.test3()
        {
           
            Console.WriteLine("this is C");
        }
        void B.test2()
        {
            Console.WriteLine("this is B");
        }
        void A.test()
        {
            Console.WriteLine("this is A second");
        }
    }
    class Program
    {
        public static void Main()
        {
            D d = new D();
            d.test();

            ((A)d).test();
            ((B)d).test2();

            ((C)d).test3();

        }
    }
}