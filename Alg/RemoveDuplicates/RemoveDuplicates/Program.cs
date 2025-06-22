
int[] nums = [1,1,2]; // Input array
int[] expectedNums = []; // The expected answer with correct length

int k = removeDuplicates(nums); // Calls your implementation

int assert  == expectedNums.length;
for (int i = 0; i < k; i++)
{
    assert nums[i] == expectedNums[i];
}
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)

        {
            return 0;
        }
        int j = 0;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[j])
            {
                nums[i] = nums[j];
            }
            else
            {
                nums[++j] = nums[i];
            }

        }
        return j + 1;
    }
}
