using System;
using System.Collections.Generic;

class Enigma
{
    static void Main()
    {

        string encryptedMessage = Console.ReadLine();
        string command = Console.ReadLine();
        while (command != "Decode")
        {
            string[] commandArgs = command.Split('|');
            string intriction = commandArgs[0];

            if (intriction == "Move")
            {
                int nLetters = int.Parse(commandArgs[1]);
                encryptedMessage = encryptedMessage.Substring(nLetters) + encryptedMessage.Substring(0, nLetters);
            }
            else if (intriction == "Insert")
            {
                int index = int.Parse(commandArgs[1]);
                string value = commandArgs[2];
                encryptedMessage = encryptedMessage.Insert(index, value);
            }
            else if (intriction == "ChangeAll")
            {
                string substring = commandArgs[1];
                string replacment = commandArgs[2];
                encryptedMessage = encryptedMessage.Replace(substring, replacment);


            }
            command = Console.ReadLine();
        }
        Console.WriteLine($"The decrypted message is: {encryptedMessage}");

    }
}