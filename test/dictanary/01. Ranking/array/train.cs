using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class train
    {
        static void Main(string[] args)
        {
            int wagon = int.Parse(Console.ReadLine());
            int number=int.Parse(Console.ReadLine());
            int[] array=new int[wagon];
            int sum = 0;

           
            
            for (int i = 1; i <= wagon; i++)
            {
               sum += array[i];
                
                
            }
            Console.WriteLine(sum);

        }
    }
}