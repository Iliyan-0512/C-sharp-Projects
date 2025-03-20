using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string LastName = Console.ReadLine();
            Console.WriteLine($"He is {FirstName} {LastName}");
        }
    }
}