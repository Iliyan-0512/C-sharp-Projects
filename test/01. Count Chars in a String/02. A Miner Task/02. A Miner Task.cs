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
            //List<string> list =Console.ReadLine().Split(" ").ToList();
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantities = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources))
                {
                    items[resources] = 0;
                }
                items[resources] += quantities;
                resources = Console.ReadLine();
            }
            foreach (var currRecou in items)
            {
                Console.WriteLine($"{currRecou.Key} -> {currRecou.Value}");
            }




        }
    }
}