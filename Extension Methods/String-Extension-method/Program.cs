using String_Extension_method;
namespace stringExtension
{
    class Program
    {
        public static void Main()
        {
            string s = "GOOD morning";

            s.Display();
            StringHelper.Display2(s);
        }
    }
}