using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\iliyan\\proggraming\\task\\SWU\\Charts\\Charts\\file1.txt";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                var r = line.Split(new char[] { ' ', ',', '.', }, StringSplitOptions.RemoveEmptyEntries);
               
                foreach (var kv in r) 
                {
                    if (!dict.ContainsKey(kv))
                    {
                        dict.Add(kv, 1);
                    }
                    else
                    {
                        dict[kv] = dict[kv] + 1;
                    }
                    foreach (var k in dict.Keys)
                    {
                        Console.WriteLine($"{k}=>{dict[k]}");
                    }
                }

            }
            var workingDirectory = Path.GetDirectoryName(fileName);
            var fn = Path.GetFileNameWithoutExtension(fileName);

            string fileName2 = Path.Combine(workingDirectory, fn +  ".charts.txt");
            using (StreamWriter sw= new StreamWriter(fileName2))
            {
                foreach (var k in dict.Keys)
                {
                    sw.WriteLine($"{k}=>{dict[k]}");
                    
                }
                Console.WriteLine("You have successfully saved the data");

            }


        }
       
    }
}
