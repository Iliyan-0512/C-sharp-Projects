using System;

namespace Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read input data for persons and products
                string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, Person> people = new Dictionary<string, Person>();
                Dictionary<string, Product> products = new Dictionary<string, Product>();

                // Parse persons
                foreach (var personData in peopleInput)
                {
                    var personInfo = personData.Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);
                    people[name] = new Person(name, money);
                }

                // Parse products
                foreach (var productData in productsInput)
                {
                    var productInfo = productData.Split('=');
                    string name = productInfo[0];
                    decimal cost = decimal.Parse(productInfo[1]);
                    products[name] = new Product(name, cost);
                }

                // Process purchase commands
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var commandParts = command.Split();
                    string personName = commandParts[0];
                    string productName = commandParts[1];

                    if (people.ContainsKey(personName) && products.ContainsKey(productName))
                    {
                        people[personName].BuyProduct(products[productName]);
                    }
                }

                // Print results
                foreach (var person in people.Values)
                {
                    if (person.Bags.Count > 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bags)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

