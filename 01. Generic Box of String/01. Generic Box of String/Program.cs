using _01._Generic_Box_of_String;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string  input = Console.ReadLine();  // Read each string
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());  // Print the Box content in specified format
            }
        }
    }
}