using System;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main()
    {
        int[] sizes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[,] matrix = new int[sizes[0], sizes[1]];
        for (int i = 0; i < sizes[0]; i++)
        {
            var input = Console.ReadLine()
                .Split()
            .Select(int.Parse)
            .ToArray();
            for (int j = 0; j < sizes[1]; j++)
            {
                matrix[i,j] += input[j];
            }
        }
        var startRow = 0;
        var startCol = 0;
        var largest = 0;
        for (var i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (var j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                var sum = 0;
                for (var x = i; x < i + 3; x++)
                {
                    for (var y = j; y < j + 3; y++)
                    {
                        sum += matrix[x, y];
                    }
                }
                if (sum > largest)
                {
                    largest = sum;
                    startRow = i; //начало на квадрата
                    startCol = j; //начало на квадрата
                }
            }
        }

        var sb = new StringBuilder(); //за да се намали броя писане в конзолата
        sb.AppendLine($"Sum = {largest}");
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int y = startCol; y < startCol + 3; y++)
            {
                sb.Append(matrix[i, y] + " ");
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString().Trim());
    }
}
