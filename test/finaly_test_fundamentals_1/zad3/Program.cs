using System;
using System.Collections.Generic;

class PianoPieces
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("|");
            string piece = input[0];
            string composer = input[1];
            string key = input[2];
            pieces[piece] = new string[] { composer, key };
        }

        string command;
        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] commandArgs = command.Split("|");
            string action = commandArgs[0];
            string piece = commandArgs[1];

            if (action == "Add")
            {
                string composer = commandArgs[2];
                string key = commandArgs[3];

                if (!pieces.ContainsKey(piece))
                {
                    pieces[piece] = new string[] { composer, key };
                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
                else
                {
                    Console.WriteLine($"{piece} is already in the collection!");
                }
            }
            else if (action == "Remove")
            {
                if (pieces.ContainsKey(piece))
                {
                    pieces.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
            else if (action == "ChangeKey")
            {
                string newKey = commandArgs[2];
                if (pieces.ContainsKey(piece))
                {
                    pieces[piece][1] = newKey;
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
        }

        foreach (var kvp in pieces)
        {
            Console.WriteLine($"{kvp.Key} -> Composer: {kvp.Value[0]}, Key: {kvp.Value[1]}");
        }
    }
}
