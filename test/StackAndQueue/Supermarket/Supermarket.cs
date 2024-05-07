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
            
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string commnad = Console.ReadLine();
                
                if (commnad == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else if (commnad == "Paid")
                {
                    foreach (string line in queue)
                    {
                        Console.WriteLine(line);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(commnad);
                }
                

            }
        }
    }
}