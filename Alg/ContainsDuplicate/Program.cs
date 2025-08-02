internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 1];
        Solution solution = new Solution();
        solution.ContainsDuplicate(array);
        Console.WriteLine(solution);
    }
}