using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Dictionary<char, int> charCounter = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ')
            {
                if (charCounter.ContainsKey(c))
                {
                    charCounter[c]++;
                }
                else
                {
                    charCounter[c] = 1;
                }
            }
        }

        Console.WriteLine("Character occurrences:");
        foreach (var kvp in charCounter)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}