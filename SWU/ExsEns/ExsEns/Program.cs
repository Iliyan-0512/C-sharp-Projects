using ExsEns;

internal class Program
{
    private static void Main(string[] args)
    {
       Laptop laptop = new Laptop();
        laptop.TurnOn();
        
        Console.WriteLine("Enter program");
        string programName=Console.ReadLine();
        laptop.StartUsinProgram(programName);
        Console.WriteLine("Enter adress");
        string browse = Console.ReadLine();
        laptop.Browse(browse);
        laptop.TurnOff();

        laptop.Brand = "Lenovo";
        laptop.CPU = "Intel i7";
        laptop.GPU = "NVIDIA RTX 4060";
        laptop.RAM = "16GB";
        laptop.DiskType = "SSD";
        laptop.Price = 2399.99;
        Console.WriteLine(laptop.ToString());
    }
}