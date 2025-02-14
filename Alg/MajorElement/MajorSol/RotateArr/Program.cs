using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = int.Parse(Console.ReadLine());
            RotateArr(nums, k);

            Console.WriteLine(string.Join(",", nums));


        }
        public static void RotateArr(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[(i + k) % n] = nums[i];

            }
            for (int i = 0; i < n; i++)
            {
                nums[i] = res[i];
            }

        }
    }
}
