using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 5, 6, 7, 8, 9, 1010, 2, 2, 1, 434, 324 };
            var lowBUmber = arr1.Where(n => n < 5);
            foreach(var number in lowBUmber)
            {
                Console.Write(",",number);
            }
           

        }
       
    }
}