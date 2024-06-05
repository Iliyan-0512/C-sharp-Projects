using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var Person = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var persons = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                Person.Add(persons);

            }
            var persentage=decimal.Parse(Console.ReadLine());
            Person.ForEach(p => p.Increasing(persentage));
            Person.ForEach(p=> Console.WriteLine(p.ToString()));

        }
    }
}