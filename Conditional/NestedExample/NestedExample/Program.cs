using System;

namespace NestedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Double percentage;
            string grade;
            Console.Write("Enter the Percentage: ");
            percentage = double.Parse(Console.ReadLine());
            if (percentage >= 80)
            {
                grade = "Distinction";
            }
            else if (percentage < 80 && percentage >= 60)
            {
                grade = "First Division";
            }
            else if (percentage < 60 && percentage >= 45)
            {
                grade = "Second Division";
            }
            else
            {
                grade = "N/A";
            }
            Console.Clear();

            Console.WriteLine("Your Percentage is {0}: ", percentage);
            Console.WriteLine("Your Grade is {0}: ", grade);
            Console.ReadLine();
        }
    }
}
