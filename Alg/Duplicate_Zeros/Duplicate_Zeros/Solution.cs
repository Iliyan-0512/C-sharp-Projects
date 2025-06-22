public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int lenght = arr.Length;
        for (int i = 0; i < lenght - 1; i++)
        {
            if (arr[i] == 0)
            {
                
                arr[i + 1] = 0;
                lenght++;
            }
        }

    }
}