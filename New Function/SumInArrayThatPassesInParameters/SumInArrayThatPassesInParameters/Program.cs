using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInArrayThatPassesInParameters
{
    class Program
    {
        static void sum()
        {

            int[] add = new int[100];
            int sum = add[0];

            Console.Write("How many numbers you want to add: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Enter the Number: ", i+1);
                add[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                sum = sum + add[i];
            }

            Console.WriteLine("\nThe sum is {0}", sum);

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            sum();
        }
    }
}
