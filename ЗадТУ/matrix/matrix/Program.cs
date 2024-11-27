using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sumEvenOnOddRows = 0;
            int sumOddOnEvenCols = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                for (int col = 0; col < matrix.GetLength(1); col++) 
                {
                    if ((row + 1) % 2 != 0 && matrix[row, col] % 2 == 0)
                    {
                        sumEvenOnOddRows += matrix[row, col];
                    }
                    if ((row + 1) % 2 == 0 && matrix[row, col] % 2 != 0)
                    {
                        sumOddOnEvenCols += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumEvenOnOddRows);
            Console.WriteLine(sumOddOnEvenCols);
        }
    }
}
