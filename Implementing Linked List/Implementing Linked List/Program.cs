using Implementing_Linked_List;
using System;

namespace ImplementingDoublyList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList();
            list.AddFirst(3);
            Console.WriteLine(string.Join(", ", list.ToArray()));
            list.AddFirst(2);
            Console.WriteLine(string.Join(", ", list.ToArray()));
            list.AddFirst(1);
            Console.WriteLine(string.Join(", ", list.ToArray()));

            list.AddFirst(0);
            list.AddLast(4);
            Console.WriteLine(string.Join(", ", list.ToArray()));

            list.AddLast(100);
            Console.WriteLine(string.Join(", ", list.ToArray()));

            list.RemoveFirst();
            Console.WriteLine(string.Join(", ", list.ToArray()));

            list.RemoveLast();
            Console.WriteLine(string.Join(", ", list.ToArray()));

            list.AddLast(5);
            Console.WriteLine(string.Join(", ", list.ToArray()));

            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(", ", list.ToArray()));
            list.ForEach();


        }
        static void PritntConsole(int i)
        {
            Console.WriteLine(123);
        }
    }
}