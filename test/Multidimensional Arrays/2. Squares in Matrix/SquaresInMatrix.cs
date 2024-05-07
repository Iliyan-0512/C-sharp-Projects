using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            //read sizes matrix
            string[] sizes = Console.ReadLine().Split(new char[] { ' ', ' ' });
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            // create matrix

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                   

                    if (matrix[row, col] == matrix[row, col + 1] &&
                         matrix[row, col] == matrix[row + 1, col] &&
                         matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}