using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Arrayrotation
    {
        static void Main(string[] args)
        {
            int[] number=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count=int.Parse(Console.ReadLine());
            count = count % number.Length;

            for (int i = 1; i <= count; i++)
            {
                int temp = number[0];
                for (int j = 1; j<number.Length ; j++)
                {
                    number[j-1] = number[j];
                }
                number[number.Length-1]=temp;
            }

            Console.WriteLine(string.Join(" ", number));

        }
    }
}