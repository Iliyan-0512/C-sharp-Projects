using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int wagon = int.Parse(Console.ReadLine());
            int[] people = new int[wagon];
            int sum = 0;

            for (int i = 0; i < wagon; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                people[i] = input;

            }
            foreach (int i in people)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            Console.WriteLine(sum);


        }
    }
}