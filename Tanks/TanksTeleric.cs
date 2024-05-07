using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine().ToUpper();
            int x = 0;
            int y = 0;
            for (int i = 1; i < command.Count(); i++)
            {
                char current = command[i];
                if (current == 'R')
                {
                    x += 1;
                }
                else if (current == 'L')
                {
                    x -= 1;
                }
                else if (current == 'D')
                {
                    y -= 1;
                }
                else if (current == 'U')
                {
                    y += 1;
                }
            }
            Console.WriteLine($"{x}, {y}");

        }
    }
}