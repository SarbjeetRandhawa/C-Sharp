using System;
namespace multiple
{
    public interface Camera
    {
        public void test();
       
    }
    public interface Phone
    {

        public void test();
        
       
    }

    class Smartdevice : Camera , Phone
    {

        void Phone.test()
        {
            Console.WriteLine("this is phone");
        }
        void Camera.test()
        {
            Console.WriteLine("this is camera");
        }
        public void test()
        {
            Console.WriteLine("this is smartphone");
        }
    }

    class Program
    {
        public static void Main()
        {
             Smartdevice s = new();
             s.test();
             ((Phone)s).test();
            ((Camera)s).test();

        }
    }
}