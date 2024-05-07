using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ComapanyUser
    {
        static void Main(string[] args)
        {
            var companyAndEmployees = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companyAndEmployees.ContainsKey(companyName))
                {
                    companyAndEmployees[companyName] = new List<string>();
                }

                if (!companyAndEmployees[companyName].Contains(employeeId))
                {
                    companyAndEmployees[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }
            foreach (var company in companyAndEmployees)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}


