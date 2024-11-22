﻿using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        static long Factorial(int n)
        {
            if (n ==1) return 1;

            return n*Factorial(  n - 1);
        }
    }
}