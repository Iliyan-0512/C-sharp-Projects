using System;

namespace SpiralMatrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine()); 
                int[,] matrix = new int[N, N]; 

                int number = 1; 
                int top = 0; 
                int bottom = N - 1; 
                int left = 0; 
                int right = N - 1; 

                while (number <= N * N)
                {
                   
                    for (int col = left; col <= right; col++)
                    {
                        matrix[top, col] = number;
                        number++;
                    }
                    top++;

                  
                    for (int row = top; row <= bottom; row++)
                    {
                        matrix[row, right] = number;
                        number++;
                    }
                    right--;

                    
                    if (top <= bottom)
                    {
                      
                        for (int col = right; col >= left; col--)
                        {
                            matrix[bottom, col] = number;
                            number++;
                        }
                        bottom--;
                    }

                   
                    if (left <= right)
                    {
                       
                        for (int row = bottom; row >= top; row--)
                        {
                            matrix[row, left] = number;
                            number++;
                        }
                        left++;
                    }
                }

               
                for (int row = 0; row < N; row++)
                {
                    for (int col = 0; col < N; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine(); 
                }
            }
        }
    }
}
