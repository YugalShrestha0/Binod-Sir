using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumberGreaterAsParameter
{
    class Program
    {
        static void greatest(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("{0} is greatest number", x);
            }
            else
            {
                Console.WriteLine("{0} is greatest number", y);
            }
        }
        static void Main(string[] args)
        {
            greatest(10, 9);
            Console.ReadLine();
        }
    }
}
