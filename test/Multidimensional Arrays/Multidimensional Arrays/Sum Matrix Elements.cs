using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read matrix sizes
           string[] sizes=Console.ReadLine().Split(new char[] { ' ', ',' },
               StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizes[0]);
            int colums = int.Parse(sizes[1]);
            // Initialize the matrix
            int[,] matrix = new int[rows, colums];
            // Read matrix elements
            for (int i = 0; i < rows; i++)
            {
                string[] rowElements = Console.ReadLine().Split(new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = int.Parse(rowElements[j]);
                }
            }

            // Calculate count of rows, count of columns, and sum of matrix elements
            int rowCount = matrix.GetLength(0);
            int columnCount= matrix.GetLength(1);
            int sum = 0;
            foreach (int element in matrix)
            {
                sum+= element;
            }
            // Print the results
            Console.WriteLine(rowCount);
            Console.WriteLine(columnCount);
            Console.WriteLine(sum);
        }
    }
}