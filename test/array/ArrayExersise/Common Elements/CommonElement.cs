using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class CommonElement
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();
            foreach (string item in array1)
            {
                foreach (string item2 in array2)
                {
                    if (string.Compare(item, item2) == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }


        }
    }
}