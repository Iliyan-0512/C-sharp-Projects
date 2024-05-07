using System;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> boxes = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string box=Console.ReadLine();
                boxes.Add(box);
            }
            string[] SwapCommand = Console.ReadLine().Split();
            int index1 = int.Parse(SwapCommand[0]);
            int index2 = int.Parse(SwapCommand[1]);
            SwapElements(boxes, index1, index2);
            foreach (string box in boxes)
            {
                boxes.Add(box);
            }

        }
        static void SwapElements<T>(List<T> list, int index1, int index2)
        {
           T temp = list[index1];

            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}