using Matrix;

namespace matrix
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Enter number of rows for matrix A: ");
            int chose;
            bool validInput = false;
            do
            {
                Console.WriteLine("Enter valid ");
                string input = Console.ReadLine();
                
            } while (true);
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns for matrix A  ");
            int colsA = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsA, colsA];

            MatrixTask matrixProp = ReadMatrix(matrixA, matrixB);
            Menu();
            int[,] matrixC = new int[rowsA, colsA];
           chose = int.Parse(Console.ReadLine());

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
                
                bool validInput = false;

                do
                {
                    Console.Write("Въведи избор (0-3): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out chose) )
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден избор. Опитай отново.");
                    }
                } while (!validInput);
            }

        }

        private static MatrixTask ReadMatrix(int[,] matrixA, int[,] matrixB)
        {
            MatrixTask matrixProp = new MatrixTask(matrixA);
            Console.WriteLine("First Matrix");

            ValidInput(matrixA);

            Console.WriteLine("===============");
            Console.WriteLine("Secound Matrix");
            ValidInput(matrixB);

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
        public static void ValidInput(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value;
                    bool validInput = false;

                    do
                    {
                        Console.Write($"Enter element [{i},{j}]: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out value))
                        {
                            validInput = true;
                            matrix[i, j] = value;
                        }
                        else
                        {
                            Console.WriteLine("incorect input");
                        }


                    } while (!validInput);
                }
            }
        }
    }
}
