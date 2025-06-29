using System;
using System.Diagnostics.Metrics;
using ManageStore;
using MenuReflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Thread t1 = new Thread(() => ShowTime());
        t1.Start();
        var menu = new ReplMenu(typeof(Program));
        menu.Run();


    }

    private static void ShowTime()
    {
        while (true)
        {
            Object _object= new object();
            lock (_object)
            {
                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(60, 1);
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                Console.SetCursorPosition(left, top);
            }


            Thread.Sleep(10);
        }
        
    }

    [MenuItem("Add Product", 1, false)]
    public static void AddProduct()
    {


        using (var dbContext = new AppDbContext())
        {
            Console.WriteLine("Enter name of product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter serial number");

            int serialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose unit of measurement:");
            foreach (var value in Enum.GetValues(typeof(Unit)))
            {
                Console.WriteLine($"{(int)value} - {value}");
            }

            Console.WriteLine("Enter unit of measurement (Kilograms, Grams, Liter):");
            string input = Console.ReadLine();

            Unit selectedUnit;
            while (!Enum.TryParse(input, true, out selectedUnit))
            {
                Console.WriteLine("Invalid input. Please enter one of: Kilograms, Grams, Liter");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter price");
            double price = double.Parse(Console.ReadLine());

            var product = new Product
            {
                Name = name,
                SerianNumber = serialNumber,
                MeasurId = selectedUnit,
                Price = price,

            };

            dbContext.Products.Add(product);

            dbContext.SaveChanges();

            Console.WriteLine("Product added successfully!");
        }

    }
    [MenuItem("Remove Product", 2, false)]
    public static void RemoveProduct()
    {
        using (var dbContext = new AppDbContext())
        {
            var x = dbContext.Products.FirstOrDefault(e => e.Id == 1);
            dbContext.Products.Remove(x);
            Console.WriteLine("nice");
        }
    }
    [MenuItem("Show All", 3, false)]
    public static void ShowAll()
    {
        using (var dbContext = new AppDbContext())
        {
            var x = dbContext.Products.Select(e => e.Name).ToList();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }


        }
    }
    [MenuItem("Exit", 4, true)]
    public static void Exit()
    {
        Environment.Exit(0);
    }

}
