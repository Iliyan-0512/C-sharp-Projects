using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            var errorMessages = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    errorMessages.Add(ex.Message);
                }
            }

            var percentage = decimal.Parse(Console.ReadLine());

           
            foreach (var errorMessage in errorMessages)
            {
                Console.WriteLine(errorMessage);
            }

           
            people.ForEach(p => p.Increasing(percentage));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
