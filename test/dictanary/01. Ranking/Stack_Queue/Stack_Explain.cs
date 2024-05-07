using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{

}
class stack
{
    static void Main()
    {
        // Creating a stack of integers
        Stack<int> myStack = new Stack<int>();

        // Pushing elements onto the stack
        myStack.Push(20);
        myStack.Push(10);
        myStack.Push(30);
        myStack.Push(34);
        myStack.Push(2);

        // Using foreach to iterate over the elements in the stack
        Console.WriteLine("Elements in the stack:");
        foreach(int element in myStack)
        {
            Console.WriteLine(element);
        }

        // Pop an element from the stack
        int poppedElement = myStack.Pop();
        Console.WriteLine($"\nPopped element: {poppedElement}");

        // Peek at the top element without removing it
        int peekedElement = myStack.Peek();
        Console.WriteLine($"Peeked element: {peekedElement}");

        // Check if the stack contains a specific element
        int searchElement = 345;
        bool containsElement = myStack.Contains(searchElement);
        Console.WriteLine($"\nDoes the stack contain {searchElement}? {containsElement}");

        // Convert the stack to an array
        int[] arrayFromStack = myStack.ToArray();
        Console.WriteLine("\nElements in the array from the stack:");
        foreach (int element in arrayFromStack)
        {
            Console.WriteLine(element);
        }

        // Get the count of elements in the stack
        int stackCount = myStack.Count;
        Console.WriteLine($"\nNumber of elements in the stack: {stackCount}");
    }
}




