using System;
using System.Linq;

class JaggedArrayModification
{
    static void Main()
    {
        // Read the number of rows for the matrix
        int rows = int.Parse(Console.ReadLine());
        int[][] matrix = new int[rows][];

        // Populate the matrix
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        string command= Console.ReadLine();
        while ((command == "END"))
        {
            string[] parts = command.Split(' ');
            int row = int.Parse(parts[1]);
            int col = int.Parse(parts[2]);
            int value = int.Parse(parts[3]);

            // Check if the coordinates are valid
            if (row < 0 || row >= rows || col < 0 || col >= matrix[row].Length)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            // Apply the modification based on the command
            if (parts[0] == "Add")
            {
                matrix[row][col] += value;
            }
            else if (parts[0] == "Subtract")
            {
                matrix[row][col] -= value;
            }
        }

        // Output the final state of the matrix
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(String.Join(" ", matrix[i]));
        }
    }
}
