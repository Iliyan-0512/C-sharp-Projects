internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = [-20, 8, -6, -14, 0, -19, 14, 4];
       Solution solution = new Solution();
        
        Console.WriteLine(solution.CheckIfExist(arr));
    }
}