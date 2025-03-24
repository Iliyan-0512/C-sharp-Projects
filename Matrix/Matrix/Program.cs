using Matrix;

namespace matrix
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Enter number of rows for matrix A: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns for matrix A  ");
            int colsA = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsA, colsA];

            MatrixTask matrixProp = ReadMatrix(matrixA, matrixB);
            Menu();
            int[,] matrixC = new int[rowsA, colsA];
            int chose = int.Parse(Console.ReadLine());
            while (chose != 0)
            {
                if (chose == 1)
                {
                    matrixC = matrixProp.MultiplayMatrix(matrixA, matrixB);
                    matrixProp.Print(matrixC);
                }
                else if (chose == 2)
                {
                    matrixC = matrixProp.MatrixAddition(matrixA, matrixB);
                    matrixProp.Print(matrixC);
                }
                else
                {
                    matrixC = matrixProp.SubtractionMatrix(matrixA, matrixB);
                    matrixProp.Print(matrixC);
                }
                Menu();
                chose=int.Parse(Console.ReadLine());
            }

        }

        private static MatrixTask ReadMatrix(int[,] matrixA, int[,] matrixB)
        {
            MatrixTask matrixProp = new MatrixTask(matrixA);
            Console.WriteLine("First Matrix");

            matrixProp.ReadMatrix(matrixA);
            Console.WriteLine("===============");
            Console.WriteLine("Secound Matrix");
            matrixProp.ReadMatrix(matrixB);
            Console.WriteLine("===============");
            return matrixProp;
        }

        public static void Menu()
        {

            Console.WriteLine("Select an option");
            Console.WriteLine("1-multiplication of matrix");
            Console.WriteLine("2-MatrixAddition of matrix");
            Console.WriteLine("3-SubtractionMatrix of matrix");
            Console.WriteLine("0-Exit");

        }
    }
}
