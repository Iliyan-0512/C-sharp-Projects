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
class Queue
{
    static void Main()
    {
        // Creating a queue of strings
        Queue<string> myQueue = new Queue<string>();

        // Enqueue elements to the queue
        myQueue.Enqueue("Apple");
        myQueue.Enqueue("Banana");
        myQueue.Enqueue("Cherry");

        // Using Dequeue to remove and retrieve the front element
        string dequeuedElement = myQueue.Dequeue();
        Console.WriteLine($"Dequeued element: {dequeuedElement}");

        // Using Peek to inspect the front element without removal
        string peekedElement = myQueue.Peek();
        Console.WriteLine($"Peeked element: {peekedElement}");

        // Check if the queue contains a specific element
        bool containsElement = myQueue.Contains("Banana");
        Console.WriteLine($"Does the queue contain Banana? {containsElement}");

        // Convert the queue to an array
        string[] arrayFromQueue = myQueue.ToArray();
        Console.WriteLine("\nElements in the array from the queue:");
        foreach (string element in arrayFromQueue)
        {
            Console.WriteLine(element);
        }

        // Get the count of elements in the queue
        int queueCount = myQueue.Count;
        Console.WriteLine($"\nNumber of elements in the queue: {queueCount}");
    }
}




