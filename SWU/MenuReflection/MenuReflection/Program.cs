using MenuReflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var menu = new ReplMenu(typeof(Program));
        menu.Run();
    }
    [MenuItem("option 1", 1, false)]
    public static
        void Function1()
    {
        Console.WriteLine("Nice");
    }
    [MenuItem("option 2", 2, true)]
    public static void Function2()
    {
        Console.WriteLine("Nice2");
    }

}