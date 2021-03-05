using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIstributionOfChocolate
{
    class Program
    {
        static void chocolate()
        {
            {
                string[] name = new string[10];
                int[] roll = new int[10];

                Console.Write("How many names you want to enter: ");
                int n = int.Parse(Console.ReadLine());

                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("\nEnter the student name: ");
                    name[i] = Console.ReadLine();

                    Console.Write("Enter the roll number: ");
                    roll[i] = int.Parse(Console.ReadLine());
                }

                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    if (roll[i] % 3 == 0)
                    {
                        Console.WriteLine("{0}. {1}", roll[i], name[i]);
                    }
                }

                Console.ReadLine();
            } 
        }
        static void Main(string[] args)
        {
            chocolate();
        }
    }
}
