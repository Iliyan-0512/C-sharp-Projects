using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bags;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public IReadOnlyList<Product> Bags
        {
            get { return this.bags.AsReadOnly(); }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.bags = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                this.bags.Add(product);
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
        }
    }
}
    
