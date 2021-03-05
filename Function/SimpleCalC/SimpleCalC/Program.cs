using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalC
{
    class Program
    {
        public static double num1 = 0, num2 = 0;

        public static void enterValue()
        {
            Console.Write("Enter the First number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            num2 = double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Console.WriteLine("Enter 1 for Addition");
                Console.WriteLine("Enter 2 for Subtraction");
                Console.WriteLine("Enter 3 for Multiplication");
                Console.WriteLine("Enter 4 for Division");
                Console.WriteLine("Enter 5 for Exit");


                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        addition();
                        break;

                    case 2:
                        subtraction();
                        break;

                    case 3:
                        multiplication();
                        break;

                    case 4:
                        division();
                        break;

                    case 5:
                        x = 2;
                        break;
                }
            }

            Console.ReadLine();
        }

        public static void addition()
        {
            enterValue();
            Console.WriteLine("\n");
            double sum = num1 + num2;
            Console.WriteLine("The Addition of " + num1 + " and " + num2 + " is : {0}", sum);
            Console.WriteLine("\n");
        }

        public static void subtraction()
        {
            enterValue();
            Console.WriteLine("\n");
            double difference = num1 - num2;
            Console.WriteLine("The of subtraction " + num1 + " and " + num2 + " is : {0}", difference);
            Console.WriteLine("\n");
        }

        public static void multiplication()
        {
            enterValue();
            Console.WriteLine("\n");
            double multiply = num1 * num2;
            Console.WriteLine("The of multiplication " + num1 + " and " + num2 + " is : {0}", multiply);
            Console.WriteLine("\n");
        }

        public static void division()
        {
            enterValue();
            Console.WriteLine("\n");
            double divide = num1 / num2;
            Console.WriteLine("The of division " + num1 + " and " + num2 + " is : {0}", divide);
            Console.WriteLine("\n");
        }
    }
}
