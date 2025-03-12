internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matrixA = new double[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
        double[,] matrixB = new double[,] { { 2, 2 }, { 2, 2 }, { 3, 3 } }; ;
        double[,] result = new double[,] { { 3, 3 }, { 2, 2 }, { 3, 3 } }; ;
        Random random = new Random();
        ReadMatrix(matrixA, matrixB, random);
        PrintMatrix(result);
        Console.WriteLine();
        MultiplyerMatrix(matrixA, matrixB, result);
        PrintMatrix(result);
    }

    private static void ReadMatrix(double[,] matrixA, double[,] matrixB, Random random)
    {
        for (int i = 0; i <= matrixA.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= matrixB.GetUpperBound(1); j++)
            {
                {
                    matrixA[i, j] = random.Next(1, 101);
                }

            }
        }
    }

    public static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
    public static double[,] MultiplyerMatrix(double[,] matrixA, double[,] matrixB, double[,] matrixC)
    {

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(1); k++)
                {
                    matrixC[i, k] += matrixA[i, k] * matrixB[k, j];

                }
            }
        }
        return matrixC;
    }
}