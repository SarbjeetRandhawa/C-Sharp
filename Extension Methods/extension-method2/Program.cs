using Extensionmethod;
namespace Etension_Method
{
    class Program
    {
        public static void Main()
        {
            OldClass o = new();
            o.display1();
            o.display2(100);
            NewClass.display1(o);


        }
    }
}