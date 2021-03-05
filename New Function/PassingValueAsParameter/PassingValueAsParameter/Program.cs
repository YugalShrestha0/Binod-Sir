using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValueAsParameter
{
    class Program
    {
        static void calculation(int x, int y, int z)
        {
            int product = x * y * z;
            Console.WriteLine("The product of {0}, {1} and {2} is {3}", x, y, z, product);
        }
        static void Main(string[] args)
        {
            calculation(10, 5, 6);
            Console.ReadLine();
        }
    }
}
