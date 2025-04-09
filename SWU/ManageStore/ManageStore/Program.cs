using System;
using ManageStore;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
        int choose = int.Parse(Console.ReadLine());
        while (choose != 0)
        {
            switch (choose)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    RemoveProduct();
                    break;
                case 3:
                    ShowAll();
                    break;
            }
            Menu();
            choose = int.Parse(Console.ReadLine());
        }


    }

    private static void Menu()
    {
        Console.WriteLine("Hi, choose one of the next options");
        Console.WriteLine("0-exit");
        Console.WriteLine("1-add product");
        Console.WriteLine("2-withdraw of product");
        Console.WriteLine("3-list with all products");
    }
    private static void AddProduct()
    {


        using (var dbContext = new AppDbContext())
        {
            Console.WriteLine("Enter name of product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter serial number");

            int serialNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price");
            double price = double.Parse(Console.ReadLine());

            var product = new Product
            {
                Name = name,
                SerianNumber = serialNumber,

                Price = price,

            };

            dbContext.Products.Add(product);

            dbContext.SaveChanges();

            Console.WriteLine("Product added successfully!");
        }

    }
    private static void RemoveProduct()
    {
        using (var dbContext = new AppDbContext())
        {
            var x=dbContext.Products.FirstOrDefault(e=>e.Id==1);
            dbContext.Products.Remove(x);
            Console.WriteLine("nice");
        }
    }
    private static void ShowAll()
    {
        using (var dbContext = new AppDbContext())
        {
            var x = dbContext.Products.Select(e=>e.Name).ToList();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            
          
        }
    }
    
}
