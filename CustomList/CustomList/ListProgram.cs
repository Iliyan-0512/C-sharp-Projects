using System;

namespace CustomList
{
    internal class ListProgram
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.RemoveAt(0);
            list.RemoveAt(1);
            list.RemoveAt(2);
            list.Contains(10);
            list.Contains(20);
            
            for (int i = 0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
