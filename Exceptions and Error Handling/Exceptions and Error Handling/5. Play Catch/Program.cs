using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            int exceptionCount = 0;
            while (exceptionCount < 3)
            {
                string command = Console.ReadLine();
                string[] arr = command.Split();
                try
                {
                    string input = arr[0];


                    if (input == "Replace")
                    {
                        int index = int.Parse(arr[1]);
                        int element = int.Parse(arr[2]);
                        
                        if (index >= 0 && index <= arr.Length)
                        {

                            number[index] = element;
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                    else if (input == "Print")
                    {
                        int startIndex = int.Parse(arr[1]);
                        int endIndex = int.Parse(arr[2]);
                       
                        if (startIndex >= 0 && endIndex < number.Count && startIndex <= endIndex)
                        {
                            Console.WriteLine(string.Join(" ", number.Skip(startIndex).Take(endIndex - startIndex + 1)));
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                    else if (input == "Show")
                    {
                        int index = int.Parse(arr[1]);
                        if (index >= 0 && index < number.Count)
                        {
                            Console.WriteLine(number[index]);
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                }
                catch (FormatException)
                {
                    exceptionCount++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
                catch (IndexOutOfRangeException)
                {
                    exceptionCount++;
                    Console.WriteLine("The index does not exist!");
                }

            }
            Console.WriteLine(string.Join(", ", number));


        }
    }
}