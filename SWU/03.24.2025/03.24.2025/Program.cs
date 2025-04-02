using _03._24._2025;

internal class Program
{
    private static void Main(string[] args)
    {
        string name=Console.ReadLine();
        string lastName= Console.ReadLine();
        string eGN= Console.ReadLine();
        string dlushnost= Console.ReadLine();
        int salary= int.Parse(Console.ReadLine());
        Employee ivan = new Employee(name,lastName,eGN,salary,dlushnost);
        Console.WriteLine(ivan.ToString());
        
    }
}