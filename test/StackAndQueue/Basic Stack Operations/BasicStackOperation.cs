using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BasicStackOpration
    {
        static void Main(string[] args)
        {
            string[] number=Console.ReadLine().Split(" ");
            
           
            int pushElement =int.Parse( number[0]);
            int popElement = int.Parse(number[1]);
            int lookElement = int.Parse(number[2]);
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input.Take(pushElement));
        
            for (int i = 1; i <= popElement; i++)
            {
                if (stack.Count>0)
                {
                    stack.Pop();
                }   
            }
            if(stack.Contains(lookElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = stack.Count > 0 ? stack.Min() : 0;
                Console.WriteLine(smallestElement);
            }
        }
    }
}
