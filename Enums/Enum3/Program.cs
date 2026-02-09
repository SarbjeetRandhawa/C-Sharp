using System;

[Flags] 
enum Gender
{
    None = 0,  
    Male = 1,  
    Female = 2,  
    Trans = Male | Female 
}

class Program
{
    static void Main()
    {
        
        Gender g1 = Gender.Male;
        Gender g2 = Gender.Female;

        Console.WriteLine($"g1: {g1}"); 
        Console.WriteLine($"g2: {g2}"); 

        // Combine values using bitwise OR
        //Gender combined = g1 | g2;
        //Console.WriteLine($"Combined: {combined}"); // Male, Female

        Gender g3 = Gender.Trans;
        Console.WriteLine($"g3: {g3}"); 

        if (g3.HasFlag(Gender.Male) && g3.HasFlag(Gender.Female))
        {
            Console.WriteLine("g3 represents Transgender.");
        }
    }
}

//using System;
//namespace Program
//{
//    class Employee(int a ,int b)
//    {
//        public void display()
//        {
//            Console.WriteLine($"{a}  {b}");
//        }
//    }
//    class Program1
//    {
//        public static void Main()
//        {
//            Employee e = new(10, 20);
//            e.display();
//        }
//    }

//}