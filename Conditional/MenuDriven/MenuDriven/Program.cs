using System;

namespace MenuDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            double first, second;
            Console.Write("Enter the first number: ");
            first = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            second = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.multipliation");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");
            
            Console.Write("Enter your Choice 1-5: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();

            if(choice==1)
            {
                double add = first + second;
                Console.WriteLine("The sum of {0} and {1} is {2} ", first, second, add);
            }

            else if(choice==2)
            {
                double sub = first - second;
                Console.WriteLine("The difference of {0} and {1} is {2} ", first, second, sub);
            }

            else if(choice==3)
            {
                double multi = first + second;
                Console.WriteLine("The multiplication of {0} and {1} is {2} ", first, second, multi);
            }

            else if(choice==4)
            {
                double div = first / second;
                Console.WriteLine("The division of {0} and {1} is {2} ", first, second, div);
            }

            else
            {
                return;
            }

            Console.WriteLine("Do you want to Continue:y/n\t");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
            {
                goto Start;
            }

            else
            {
                return;
            }
            Console.ReadLine();
        }
    }
}
