using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            int odd=0;
            int even = 0; 
            for (int i = L; i <= R; i++)
            {
                if (L%2==0 )
                {
                    even += i;
                    L++;
                }
                else
                {
                    odd += i;
                    L++;
                }
               
            }
            Console.WriteLine(Math.Abs(even-odd)%5+2);
        }
    }
}