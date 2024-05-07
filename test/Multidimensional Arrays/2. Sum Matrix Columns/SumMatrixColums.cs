using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class SumMatrixColums
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(new char[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix= new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] RowElement = Console.ReadLine().Split(new char[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    
                    matrix[i, j] = int.Parse(RowElement[j]);
                }
            }
            int sum = 0;
            foreach (int element in matrix)
            {
                sum += element;
                Console.WriteLine(sum);
            }
           
        }
    }
}