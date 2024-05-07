using System;
using System.Collections.Generic;
using System.Linq;

class FastFood
{
    static void Main()
    {
        string[] songs = Console.ReadLine().Split(", ").ToArray();
        Queue<string> queue = new Queue<string>(songs);

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Play")
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine($"Playing {queue.Dequeue()}");
                }
                else
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
            else if (command.StartsWith("Add"))
            {
                string songToAdd = command.Split(" ")[1];
                if (!queue.Contains(songToAdd))
                {
                    queue.Enqueue(songToAdd);
                }
                else
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
            }
            else if (command == "Show")
            {
                Console.WriteLine(string.Join(", ", queue));
            }
        }
    }
}
