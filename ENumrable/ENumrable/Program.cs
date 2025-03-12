internal class Program
{
    private static void Main(string[] args)
    {
       foreach (var m in Magic())
        {
            Console.WriteLine(m);
        }

    }
    static IEnumerable<int> Magic()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return i;
        }

    }
}