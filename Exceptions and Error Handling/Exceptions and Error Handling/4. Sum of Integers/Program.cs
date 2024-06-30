using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input = Console.ReadLine();
            string[] arr = input.Split();


            

            for (int i = 0; i < arr.Length; i++)
                try
                {
                    int number = int.Parse(arr[i]);
                    sum += number;
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{arr[i]}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{arr[i]}' is out of range!");
                }
                finally
                {

                    Console.WriteLine($"Element '{arr[i]}' processed - current sum: {sum}");
                }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}