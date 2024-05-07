using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

class ActivationKeyGenerator
{
    static void Main()
    {
        string activationKey = Console.ReadLine();

        string command;
        while ((command = Console.ReadLine()) != "Generate")
        {
            string[] commandArgs = command.Split(">>>");

            if (commandArgs[0] == "Contains")
            {
                if (activationKey.Contains(commandArgs[1]))
                {
                    Console.WriteLine($"{activationKey} contains {commandArgs[1]}");
                }
                else
                {
                    Console.WriteLine("Substring not found!");
                }
            }
            else if (commandArgs[0] == "Flip")
            {
                int startIndex = int.Parse(commandArgs[2]);
                int endIndex = int.Parse(commandArgs[3]);

                if (startIndex >= 0 && endIndex <= activationKey.Length && startIndex < endIndex)
                {
                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);

                    if (commandArgs[1] == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else if (commandArgs[1] == "Lower")
                    {
                        substring = substring.ToLower();
                    }

                    activationKey = activationKey.Substring(0, startIndex) + substring + activationKey.Substring(endIndex);
                    Console.WriteLine(activationKey);
                }
            }
            else if (commandArgs[0] == "Slice")
            {
                int startIndex = int.Parse(commandArgs[1]);
                int endIndex = int.Parse(commandArgs[2]);

                if (startIndex >= 0 && endIndex <= activationKey.Length && startIndex < endIndex)
                {
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
        }

        Console.WriteLine($"Your activation key is: {activationKey}");
    }
}
