//using System;
//namespace Generic
//{
//   public  class Typegeneric<T>
//    {
//        private T[] array;

//        public Typegeneric(int size)
//        {
//            array = new T[size + 1];
//        }
//        public T getvalue(int index)
//        {
//            return array[index];
//        }
//        public void setvalue(T value , int index)
//        {
//            array[index] = value;
//        }
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            Typegeneric<int> t = new(5);

//            for(int i = 0; i < 5; i++)
//            {
//                t.setvalue(i * 5, i);
//            }
//            for(int i = 0; i <  5; i++)
//            {
//               Console.WriteLine($"{t.getvalue(i)}") ;
//            }
//        }
//    }
//}

using System;
namespace Generic
{
    public class Typegeneric<T>
    {
        private T[] array;

        public Typegeneric(int size)
        {
            array = new T[size + 1];
        }
        public T getvalue(int index)
        {
            return array[index];
        }
        public void setvalue(T value, int index)
        {
            array[index] = value;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Typegeneric<char> t = new(5);

            
            for(int i = 0; i < 5; i++)
            {
                t.setvalue((char)(97 + i), i);
            }
            for(int i = 0; i < 5; i++)
            {
                t.getvalue(i);
            }
        }
    }
}