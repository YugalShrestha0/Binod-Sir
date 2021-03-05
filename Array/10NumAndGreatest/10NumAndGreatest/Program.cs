using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10NumAndGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int large = num[0];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n{0}. Enter the number: ", i+1);
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (num[i] > large)
                {
                    large = num[i];
                }
            }

            Console.Clear();
            Console.WriteLine("\nThe Greatest Number is: {0}", large);

            Console.ReadLine();
        }
    }
}
