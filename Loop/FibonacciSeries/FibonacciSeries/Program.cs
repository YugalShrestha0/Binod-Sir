using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, n;
            Console.Write("Enter how many number do you want to print?: ");
            n = int.Parse(Console.ReadLine());

            Console.Write(b+",");

            for (int i=2;i<n;i++)
            {
                c = a + b;
                Console.Write(c+",");
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
