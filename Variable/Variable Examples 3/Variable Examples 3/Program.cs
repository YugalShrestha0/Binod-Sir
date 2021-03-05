using System;

namespace Variable_Examples_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int StudentId;
            string StudentName;
            Console.Write("\nEnter Student ID: ");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Student Name: ");
            StudentName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Student Name: {0}", StudentName);
            Console.ReadLine();
        }
    }
}
