using System;
using System.Text.RegularExpressions;

class SpaceFoodCalculator
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(#|\|)([A-Za-z\s]+)\1(\d{2}/\d{2}/\d{2})\1(\d+)\1";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(input);
        int totalCalories = 0;

        foreach (Match match in matches)
        {
            string itemName = match.Groups[2].Value;
            string expirationDate = match.Groups[3].Value;
            int calories = int.Parse(match.Groups[4].Value);
            totalCalories += calories;
        }

        int days = totalCalories / 2000;

        Console.WriteLine($"You have food to last you for: {days} days!");
        Console.WriteLine($"Total Calories: {totalCalories}");
    }
}
