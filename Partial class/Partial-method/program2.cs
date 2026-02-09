using System;
using System.Collections.Generic;
using System.Text;

namespace Partialclass
{
   partial class PartialC
    {
        public partial void Display()
        {
            Console.WriteLine($"partial method invoked with value {a + 200}");
        }
    }
}
