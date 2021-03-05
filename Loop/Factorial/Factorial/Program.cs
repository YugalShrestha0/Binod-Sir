using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, factorial=1;
            Console.Write("Enter the Factorial Number: ");
            n = int.Parse(Console.ReadLine());

            for (int i=1;i<=n;i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The factorial of " + n + " is {0}", factorial);

            Console.ReadLine();
        }
    }
}
