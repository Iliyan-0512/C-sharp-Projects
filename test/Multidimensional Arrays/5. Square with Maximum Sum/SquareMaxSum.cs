using System;
using System.Linq;

class SymbolInMatrix
{
    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        // Initialize and fill the matrix
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        // Find the 2x2 submatrix with the maximum sum
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSquareSum = matrix[row, col]
                    + matrix[row, col + 1]
                    + matrix[row + 1, col]
                    + matrix[row + 1, col + 1];

                if (currentSquareSum > maxSum)
                {
                    maxSum = currentSquareSum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        // Print the elements of the submatrix and the sum
        Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
        Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
        Console.WriteLine(maxSum);
    }
}

