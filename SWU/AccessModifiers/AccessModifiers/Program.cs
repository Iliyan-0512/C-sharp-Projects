
public class ClassA
{
    public static  const int aaa = 10;
}

public class Program
{
    public static void Main(string[] args)
    {
        ClassA classA = new ClassA();
        Console.WriteLine(classA.aaa);
        Console.ReadKey();
    }
}
