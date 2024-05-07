using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                if (i%2==0)
                {
                    arr1[i]= a;
                    arr2[i]= b;
                }
                else
                {
                    arr2[i]= a;
                    arr1[i]= b;
                }

            }
            foreach (int i in arr1)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write(item+ " ");
            }


        }
    }
}