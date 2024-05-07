using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the best sample");
            int[] bumber = { 1, 2, 3 };
            for (int i = 0; i < bumber.Length; i++)
            {
                Console.WriteLine(bumber[i]+1);
            }
        }
    }
}
