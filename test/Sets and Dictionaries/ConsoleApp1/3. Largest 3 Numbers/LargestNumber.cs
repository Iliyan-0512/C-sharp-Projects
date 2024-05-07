using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Dictanary
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sorted = numbers.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 2)
                {
                    return;
                }
                Console.Write(sorted[i] + " ");
            }
        }
    }
}