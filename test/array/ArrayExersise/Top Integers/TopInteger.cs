using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Topinteher
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < number.Length; i++)
            {
                
                if (number[i] > number[i+1] && number[i] >= 0 && number[i+1] 
                    < number.Length)
                {
                    Console.Write(number[i] + " ");
                }
            }

        }
    }
}