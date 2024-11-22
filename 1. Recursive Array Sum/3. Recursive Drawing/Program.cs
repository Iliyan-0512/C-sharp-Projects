using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Drawing(n);
        }
        static int Drawing(int n)
        {
            if (n <=0)
            {
                return 0 ;
            }
            Console.WriteLine(new string('*',n));
            int result =Drawing(n-1);
            Console.WriteLine(new string('#',n));
            return result + 1;
        }
       
       
    }
}