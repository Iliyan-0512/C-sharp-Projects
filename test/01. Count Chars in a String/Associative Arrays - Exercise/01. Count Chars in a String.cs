﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            var letters = new Dictionary<char,int>();
            foreach (var letter in word)
            {
                if (letter!=' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }
            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}