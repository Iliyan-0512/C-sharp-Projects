using Run_Time_Polymorphism_;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassB y = new ClassB();
        ClassA x = new ClassA();
        ClassB z = new ClassA();
        y.AAA(); y.BBB(); y.CCC();
        x.AAA(); x.BBB(); x.CCC();
        z.AAA(); z.BBB(); z.CCC();
        Console.ReadKey();
    }
}