using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestNumberInArrayAsParameter
{
    class Program
    {
        static void great()
        {
            int[] num = new int[100];
            int large = num[0];

            Console.Write("How many number you want to enter: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Enter the number: ", i+1);
                num [i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (num[i] > large)
                {
                    large = num[i];
                }
            }

            Console.Clear();
            Console.WriteLine("\nThe largest number is: {0}", large);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            great();
        }
    }
}
