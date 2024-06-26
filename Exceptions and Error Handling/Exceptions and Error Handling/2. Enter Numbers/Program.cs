using System;

class Program
{
    public static void Main()
    {
        try
        {


            int[] numbers = new int[10];
            int Start = 1;

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ReadNumber(Start, 100);
                Start = numbers[i];
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int ReadNumber(int start, int end)
    {
        while (true)
        {
          
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (number <= start || number >= end)
                {
                    Console.WriteLine($"Your number is not in range {start} - {end}!");
                    continue;
                }


                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
           
        }
    }
}