using Matrix;

namespace matrix
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter number of rows for matrix A: ");
            int rowsA = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns for matrix A (and rows for matrix B): ");
            int colsA = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns for matrix B: ");
            int colsB = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[colsA, colsB];

            MatrixTask matrixProp = new MatrixTask(matrixA);
            Console.WriteLine("First Matrix");

            matrixProp.ReadMatrix(matrixA);
            Console.WriteLine("===============");
            Console.WriteLine("Secound Matrix");
            matrixProp.ReadMatrix(matrixB);
            Console.WriteLine("===============");
            int[,] matrixC = matrixProp.MultiplayMatrix(matrixA, matrixB);
            matrixProp.Print(matrixC);
            Console.WriteLine("===============");

            matrixC=matrixProp.MatrixAddition(matrixA, matrixB);
            matrixProp.Print(matrixC);
            Console.WriteLine("===============");
            matrixC = matrixProp.SubtractionMatrix(matrixA, matrixB);
            matrixProp.Print(matrixC);

        }
    }
}
