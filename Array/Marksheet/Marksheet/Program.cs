using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            String StudentName;
            String[] SubjectName = new string[100];
            Double[] FullMark = new double[100];
            Double[] PassMark = new double[100];
            Double[] ObtainedMark = new double[100];
            Double TotalFullMarks = 0;
            Double TotalObtainedMarks = 0;
            Double Percentage;
            int n;

            Console.Write("Enter the name of the student: ");
            StudentName = Console.ReadLine();
            Console.Write("\nEnter the Number of Subject: ");
            n = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i=0;i<n;i++)
            {
                Console.Write("\n{0}. Subject Name: ", i+1);
                SubjectName[i] = Console.ReadLine();
                Console.Write("\nFull Marks: ");
                FullMark[i] = Double.Parse(Console.ReadLine());
                Console.Write("\nPass Marks: ");
                PassMark[i] = Double.Parse(Console.ReadLine());
                Console.Write("\nObtained Marks: ");
                ObtainedMark[i] = Double.Parse(Console.ReadLine());
                TotalFullMarks += FullMark[i];
                TotalObtainedMarks += ObtainedMark[i];
            }
            Percentage = TotalObtainedMarks / TotalFullMarks * 100;
            Console.Clear();

            Console.WriteLine("-----------------------MARKSHEET-------------------------");
            Console.WriteLine("\n{0}\t {1}\t {2}\t {3}\t", "SubjectName", "FullMark", "PassMark", "ObtainedMark");

            for (int i=0;i<n;i++)
            {
                Console.WriteLine("\n{0}\t\t {1}\t\t {2}\t\t {3}\t\t", SubjectName[i], FullMark[i], PassMark[i], ObtainedMark[i]);
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine(StudentName+ " got " +Percentage+ " percentage in exam");

            Console.ReadLine();
        }
    }
}
