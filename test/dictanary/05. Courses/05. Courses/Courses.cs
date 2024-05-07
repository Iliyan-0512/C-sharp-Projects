using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Courses
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split(":").Select(s => s.Trim()).ToList();

                string coursesName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(coursesName))
                {
                    courses[coursesName] = new List<string>();
                }

                courses[coursesName].Add(studentName);
            }

            // Print the information about each course and its registered students
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
