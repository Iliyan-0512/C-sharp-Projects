using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class TrafficJam
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();
            int totalCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < N && carQueue.Count > 0; i++)
                    {
                        string car = carQueue.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        totalCarsPassed++;
                    }
                }
                else
                {
                    carQueue.Enqueue(command);
                }
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
