using System;
using System.Collections.Generic;

namespace Ienumerable
{
    class Program
    {
        public static void Main()
        {
            List<int> l = new List<int>{ 1, 2, 5, 7, 8, 9 };

            IEnumerable<int> evennum = l.Where(e => e % 2 == 0);

            foreach(var i in evennum)
            {
                Console.WriteLine(i);
            }
        }
    }
}