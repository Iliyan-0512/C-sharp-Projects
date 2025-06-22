internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = [3, 2, 2, 3];
        int val = 3;
        Console.WriteLine(solution.RemoveElement(arr, val));
        
        Console.ReadLine();
    }
}