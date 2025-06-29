using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixTask
    {
        public int[,] Matrix { get; set; }

        public MatrixTask(int[,] matrix)
        {
            Matrix = matrix;
        }
        public void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

     
        public int[,] MultiplayMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC;
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
           
            matrixC = new int[rowsA, colsA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {

                    for (int k = 0; k < colsA; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC;
        }
        public int[,] MatrixAddition(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC;
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            ;
            matrixC = new int[rowsA, colsA];
            for (int i = 0;i < rowsA; i++)
            {
                for(int j = 0;j < colsA; j++)
                {
                    matrixC[i, j] = matrixA[i, j]+ matrixB[i,j];
                }
            }
            return matrixC;
        }
        public int[,] SubtractionMatrix(int[,]matrixA, int[,] matrixB)
        {
           int[,] matrixC;
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            matrixC = new int[rowsA, colsA];
            for(int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    matrixC[i, j]= matrixA[i, j]-matrixB[i,j];
                }

            }
            return matrixC;
        }

    }

}

