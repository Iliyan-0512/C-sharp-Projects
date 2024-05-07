using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Courses
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var nameAndGrade = new Dictionary<string, List<double>>();

            for (int i = 1; i <= rows; i++)
            {
                string name = Console.ReadLine();
                double grades = double.Parse(Console.ReadLine());
                if (!nameAndGrade.ContainsKey(name))
                {
                    nameAndGrade[name]=new List<double>();
                }
                nameAndGrade[name].Add(grades);
                
            }
            var filteredStudents = nameAndGrade
            .Where(student => student.Value.Average() >= 4.5)
            .ToDictionary(student => student.Key, student => student.Value.Average());
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }

        }
    }
}


