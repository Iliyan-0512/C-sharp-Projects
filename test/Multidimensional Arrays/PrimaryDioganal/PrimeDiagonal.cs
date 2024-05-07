using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            int[][] matrix=new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i]= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            string command = Console.ReadLine();
            while ((command == "END"))
            {
                string[] parts = command.Split(' ');
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);
                if (row < 0 || row >= rows || col < 0 || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (parts[0] == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (parts[0] == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(String.Join(" ", matrix[i]));
            }
        }

        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    int[,]matrix=new int[n,n];
        //    int primaryDiagonalSum = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        int[] element= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        //        for (int j = 0; j < n; j++)
        //        {
        //            matrix[i,j]= element[j];

        //            if (i==j)
        //            {
        //                primaryDiagonalSum += matrix[i, j];
        //            }
        //        }
        //    }
        //    Console.WriteLine(primaryDiagonalSum);

    }
}


