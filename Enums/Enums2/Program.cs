using System;

class Program
{
    
    enum Day
    {
        Sunday,     
        Monday,     
        Tuesday,    
        Wednesday,  
        Thursday,   
        Friday,     
        Saturday    
    }

    static void Main()
    {
        
        Day today = Day.Wednesday;

        
        Console.WriteLine($"Today is: {today}"); 

        
        Console.WriteLine($"Numeric value: {(int)today}"); 

        
        Console.WriteLine("\nAll days:");
        foreach (Day d in Enum.GetValues(typeof(Day)))
        {
            Console.WriteLine($"{d} = {(int)d}");
        }
    }
}
