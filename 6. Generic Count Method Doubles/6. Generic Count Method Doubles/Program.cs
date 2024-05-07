using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double number=double.Parse(Console.ReadLine());
                list.Add(number);
            }
            double compareNumber =double.Parse( Console.ReadLine());
            Console.WriteLine(Compare(list,compareNumber));
        }

        public static double Compare<T>(List<T> list, T compareNumber)
            where T : IComparable<T>
        {
            double counter = 0;
            foreach (var generic in list)
            {
                if (generic.CompareTo(compareNumber)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}