using System;
class DiagonalDifference
{
    static void Main()
    {
        // Read the size of the matrix from the console
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        // Iterate over the rows to fill the matrix
        for (int i = 0; i < n; i++)
        {
            // Read the current row, split it into numbers and fill the matrix
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        int primaryDiagonal = 0;
        int secondyDioganal = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonal+= matrix[i, i];
            secondyDioganal+= matrix[i, n-i-1];
        }
        Console.WriteLine(Math.Abs(primaryDiagonal - secondyDioganal));
    }
}
