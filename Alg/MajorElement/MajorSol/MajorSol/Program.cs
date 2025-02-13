using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(MajorityElement(nums));

        }
        public static int MajorityElement(int[] nums)
        {
            int candidate = -1;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
                else
                {
                    if (nums[i] == candidate) count++;
                    else count--;
                }
            }
            count = 0;
            for (int i=0; i < nums.Length; i++)
            {
                if (nums[i] == candidate) count++;
            }
            if(count>(nums.Length/2))
            {
                return candidate;
            }
            return -1;

            
        }
    }
}