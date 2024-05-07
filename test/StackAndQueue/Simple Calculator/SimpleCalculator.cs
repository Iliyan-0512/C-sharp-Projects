using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            
            string expression = Console.ReadLine();

            // Split the input expression by space to extract its tokens (numbers and operations).
            string[] tokens = expression.Split(' ');

            // Reverse the input tokens and push them into a Stack<string>.
            Stack<string> stack = new Stack<string>(tokens.Reverse());

            // Pop the last number. It is the current result.
            int result = int.Parse(stack.Pop());

            // Iterate through the stack and perform operations.
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int operand = int.Parse(stack.Pop());

                // Execute the operation.
                if (operation == "+")
                {
                    result += operand;
                }
                else if (operation == "-")
                {
                    result -= operand;
                }
            }

            Console.WriteLine(result);
        }
    }
}
