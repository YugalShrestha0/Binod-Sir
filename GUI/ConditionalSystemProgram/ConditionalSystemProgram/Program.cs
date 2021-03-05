using System;

namespace ConditionalSystemProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int CoronaPatient = 0;
            Console.Write("Enter the number of Patient: ");
            CoronaPatient = int.Parse(Console.ReadLine());
            if (CoronaPatient > 0)
            {
                Console.WriteLine("Lockdown will Continued");
                Console.WriteLine("Stay at home");
            }
            else
            {
                Console.WriteLine("You are free now");
            }
            Console.ReadLine();
        }
    }
}
