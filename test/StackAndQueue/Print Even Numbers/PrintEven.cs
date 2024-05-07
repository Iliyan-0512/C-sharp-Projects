using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<int> numberQueue = new Queue<int>(Array.ConvertAll(input.Split(' '), int.Parse));

           
            while (numberQueue.Count > 0)
            {
                int number = numberQueue.Dequeue();

                if (number % 2 == 0)
                {
                    Console.Write(number);

                    if (numberQueue.Count > 0 && numberQueue.Peek() % 2 == 0)
                    {
                        Console.Write(", ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}