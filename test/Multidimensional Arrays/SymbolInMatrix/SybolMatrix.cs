using System;

class SymbolInMatrix
{
    static void Main()
    {
        // Read the size of the matrix
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        // Populate the matrix with characters
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        // Read the symbol to find
        char symbol = Console.ReadLine()[0];
        bool found = false;

        // Search for the symbol in the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == symbol)
                {
                    // If found, print its position and set found to true
                    Console.WriteLine($"({i}, {j})");
                    found = true;
                    break; // Stop searching after the first occurrence
                }
            }
            if (found) break; // Break the outer loop if the symbol was found
        }

        // If the symbol was not found, print an error message
        if (!found)
        {
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
