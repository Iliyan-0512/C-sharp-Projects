using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping
{
    public class Product
    {
        private string name;
        private decimal cost;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = Name;
            }
        }
        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
            
        }
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
