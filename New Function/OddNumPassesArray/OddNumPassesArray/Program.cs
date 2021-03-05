using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumPassesArray
{
    class Program
    {
        static void oddNumber()
        {
            /*
            foreach(int i in odd)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            int[] odd = new int[100];

            Console.Write("How many number you want to enter: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Enter the number: ", i + 1);
                odd[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (odd[i] % 2 != 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            /*
            int[] odd = { 0, 5, 6, 2, 8, 7, 10, 33, 52 };
            oddNumber(odd);
            Console.ReadLine();
            */
            oddNumber();
        }
    }
}
