using System;

namespace MyApp
{
    internal class sampleLambd
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine().Select(int.Parse).ToArray();
        }
    }
}