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
            double[] nums = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToArray();
            var counts = new Dictionary<double, int>();
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }                  
                else
                {
                    counts[num] = 1;
                }            
            }       
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}