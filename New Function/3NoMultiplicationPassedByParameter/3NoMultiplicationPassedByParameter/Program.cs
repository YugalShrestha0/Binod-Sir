using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3NoMultiplicationPassedByParameter
{
    class Program
    {
        static double multiplication(double a, double b, double c)
        {
            double product = a * b * c;
            return product;
        }
        static void Main(string[] args)
        {
            double product = multiplication(50, 5, 8);
            Console.WriteLine("The product is {0}", product);
            Console.ReadLine();
        }
    }
}
