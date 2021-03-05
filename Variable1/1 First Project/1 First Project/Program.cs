using System;

namespace _1_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, address, contact;
            Console.Write("\nEnter the name of the Student: ");
            name = Console.ReadLine();
            Console.Write("\nEnter the address of the Student: ");
            address = Console.ReadLine();
            Console.Write("\nEnter the contact of the Student: ");
            contact = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DETAILS OF THE STUDENT");
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Contact: {0}", contact);
            Console.ReadLine();
        }
    }
}
