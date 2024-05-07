using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroNine = random.Next(10);
            Console.WriteLine(zeroNine);

            int dieRow = random.Next(7);

            double randomDouble = random.NextDouble();

            Console.WriteLine(randomDouble * 100);

            Console.WriteLine((float)randomDouble * 100F);
            Console.WriteLine((decimal)randomDouble * 100M);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);


        }



    }
}