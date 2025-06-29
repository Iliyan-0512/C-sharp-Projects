using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers");
        List<int> nums = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            {
                break;

            }

            if (int.TryParse(input, out int number))
            {
                nums.Add(number);
                Console.WriteLine("Add number");
            }
            else
            {
                Console.WriteLine("Error, enter correctly input:");
            }
        }



        Console.WriteLine($"MajorityElement is {MajorityElement(nums)}"); 
    }
    public static int MajorityElement(List<int> nums)
    {
        int candidate = 0;
        int count = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
                count++;
            }
            else
            {
                if (candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        count = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == candidate)
            {
                count++;
            }
        }
        if (count > nums.Count / 2)
        {
            return candidate;
        }
        return 0;





    }
}