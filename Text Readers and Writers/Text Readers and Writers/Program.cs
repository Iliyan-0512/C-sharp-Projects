using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Downloads/input.txt");
            using (reader)
            {
                int counter = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    Console.WriteLine(++counter + ". " + line);
                }
            }

        }
    }
}