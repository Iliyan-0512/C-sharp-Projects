using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messeges = Console.ReadLine();
            while (messeges != "Reveal")
            {
                string[] command = messeges.Split("|");
                if (command[0] == "InsertSpace:")
                {
                    int tokensOne = int.Parse(command[1]);
                    messeges.Insert(tokensOne, " ");
                    Console.WriteLine(messeges);


                }
                else if (command[0] == "Reverse:")
                {
                    string substring = command[1];
                    if (messeges.Contains(substring))
                    {
                        char[] charArray = substring.ToCharArray();
                        Array.Reverse(charArray);
                        substring = new string(charArray);
                        messeges = messeges.Replace(command[1], substring);
                        Console.WriteLine(messeges);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
                else if (command[0] == "ChangeAll:")
                {
                    string substring = command[1];
                    string replacement = (command[2]);

                    messeges = messeges.Replace(substring, replacement);
                    Console.WriteLine(messeges);
                }
                messeges = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {messeges}");
        }
    }
}



