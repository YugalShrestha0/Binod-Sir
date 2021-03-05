using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollnumber;
            string StudentName;
            rollnumber = 100;
            StudentName = "Yugal Kumar Shrestha";
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Roll Number: " + rollnumber);
            Console.WriteLine(StudentName + " roll number is " + rollnumber);
            Console.WriteLine("Student Name: {0}", StudentName);
            Console.WriteLine("Roll Number: {0}", rollnumber);
            Console.WriteLine("{0} roll number is {1}", StudentName, rollnumber);
            Console.ReadLine();
        }
    }
}
