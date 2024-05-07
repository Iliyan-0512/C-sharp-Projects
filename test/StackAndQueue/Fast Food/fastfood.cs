using System;
using System.Collections.Generic;
using System.Linq;

class fastfood
{
    static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());
        int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> orderQueue = new Queue<int>(orders);
        int biggestOrder = int.MinValue;

        while (orderQueue.Count > 0)
        {
            int currentOrder = orderQueue.Peek();

            if (currentOrder <= foodQuantity)
            {
                foodQuantity -= currentOrder;
                biggestOrder = Math.Max(biggestOrder, currentOrder);
                orderQueue.Dequeue();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(biggestOrder);
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", orderQueue)}");
        }
    }
}
