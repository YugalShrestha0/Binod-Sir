using System;

namespace DisplayDay_Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            int day;
            Console.Write("Enter the day Number: ");
            day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
            }

            Console.Write("Do you want to continue(y/n): ");
            char ch = char.Parse(Console.ReadLine());

            if(ch == 'y' || ch == 'Y')
            {
                goto start;
            }
            else
            {
                return;
            }

            Console.ReadLine();
        }
    }
}
