using System;

namespace DisplayDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Enter a day number: ");
            day = int.Parse(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Thrusday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Saturday");
            }

            Console.ReadLine();
        }
    }
}
