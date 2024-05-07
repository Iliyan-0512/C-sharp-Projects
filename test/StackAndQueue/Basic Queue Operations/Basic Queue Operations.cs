using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BasicStackOpration
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(" ");


            int enqueue = int.Parse(number[0]);
            int dequeue = int.Parse(number[1]);
            int lookElement = int.Parse(number[2]);
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input.Take(enqueue));
            for(int i = 0; i < dequeue; i++)
            {
                if(queue.Count > 0)
                {
                    queue.Dequeue();
                }
                
            }
            if(queue.Contains(lookElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = queue.Count > 0 ? queue.Min() : 0;
                Console.WriteLine(smallestElement);
            }
        }
    }
}
