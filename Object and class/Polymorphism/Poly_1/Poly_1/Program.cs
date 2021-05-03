using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_1
{
    class arthemetic
    {
        public void add()
        {
            int a, b;

            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);
        }

        public void add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The sum of the numbers is {0}",sum);
        }

        public void add(int x, int y, int z)
        {
            int sum = x + y + z;
            Console.WriteLine("The sum of the numbers is {0}", sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            arthemetic a = new arthemetic();
            a.add();
            a.add(5, 6);
            a.add(9, 8, 7);

            Console.ReadLine();
        }
    }
}
