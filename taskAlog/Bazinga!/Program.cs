using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           string words=Console.ReadLine();
            Dictionary<char, int> letterCount = new Dictionary<char, int>
            {
                { 'b',0 },
                { 'a',0 },
                { 'z',0 },
                { 'i',0 },
                { 'n',0 },
                { 'g',0 },
               
            };
            foreach (char item in words)
            {
                if (letterCount.ContainsKey(item))
                {
                    letterCount[item]++;

                }
            }
            letterCount['a'] /= 2;
            int maxBanners = letterCount.Values.Min();

            
            Console.WriteLine(maxBanners);
        }
    }
}