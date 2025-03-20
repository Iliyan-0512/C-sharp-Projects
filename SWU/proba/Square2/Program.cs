using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter length of side Squart");
            //int n = int.Parse(Console.ReadLine());
            //int s = n * n;
            //Console.WriteLine($"S={s}");
            //Console.WriteLine(1+1+"4"+2+1);
            Console.Write("enter number: ");
            string input = Console.ReadLine();
            int length = input.Length;

            string speed = length
              switch
            {

                <= 10 => "slow",
                <= 50 => "averege",
                <= 150 => "fast",
                _ => "very fast"
            };

            Console.WriteLine($"speed: {speed}");
        }
    }
}