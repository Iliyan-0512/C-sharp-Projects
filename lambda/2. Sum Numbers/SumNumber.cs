using System;

namespace MyApp
{
    internal class SumNumber
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            int[] numbers = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(n => int.Parse(n))                               
                                 .ToArray();


            int count = numbers.Count();


            int sum = numbers.Sum();

            Console.WriteLine(count);
            Console.WriteLine(sum);


        }
    }
}