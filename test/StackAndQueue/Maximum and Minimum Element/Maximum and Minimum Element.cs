using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BasicStackOpration
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack= new Stack<int>();
            
            for (int i = 1; i <= n; i++)
            {
                int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = tokens[0];
                
                if (command==1)
                {
                    int number = tokens[1];
                    stack.Push(number);
                }
                else if (command==2)
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if(command==3)
                {
                    if (stack.Count > 0)
                        Console.WriteLine(stack.Max());
                }
                else if (command==4)
                {
                    if (stack.Count > 0)
                        Console.WriteLine(stack.Min());
                }
               
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
