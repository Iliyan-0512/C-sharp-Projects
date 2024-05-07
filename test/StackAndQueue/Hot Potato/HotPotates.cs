using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Supermarket
    {
        static void Main(string[] args)
        {


            var children = Console.ReadLine().Split(" ");

            var number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);

            while (queue.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");




        }
    }
}
