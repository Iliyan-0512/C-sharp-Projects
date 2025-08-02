public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        bool number = false;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                number = true;
                return number;
            }
        }
        return number;
    }
}