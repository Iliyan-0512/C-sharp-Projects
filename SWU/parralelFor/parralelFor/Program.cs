

using System.Diagnostics;

internal class Program
{


    private static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
      
        int[,] matrixA = new int[7000, 7000];

        int[,] matrixB = new int[7000, 7000];
        int[,] matrixC = new int[7000, 7000];
        Random rand = new Random();


        ReadMatrix(rand, matrixA);
        ReadMatrix(rand, matrixB);
        //printMatrix(matrixA);
        //printMatrix(matrixB);
        sw.Start();
        MultiplyMatrix(matrixA, matrixB, matrixC);


        sw.Stop();
        Console.WriteLine($"Matrix multiplication took: {sw.ElapsedMilliseconds} ms");


    }

    private static void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        //for (int i = 0; i < rowsA; i++)
         Parallel.For(0, rowsA, (i) =>
        {
            //for (int j = 0; j < colsB; j++)
             Parallel.For(0, colsB, (j) => 
            {
                 matrixC[i, j] = 0;

                 for (int k = 0; k < colsA; k++)
                 {
                     matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                 }
             });
        });
        
    }


    private static void ReadMatrix(Random rand, int[,] matrix)
    {
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                matrix[i, j] = rand.Next(1, 101);
            }
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
}