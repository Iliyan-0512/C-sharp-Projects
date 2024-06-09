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
                if(name ==string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public decimal Money
        {
            get { return money; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }
        public Person(string name, decimal money, List<Product> bags)
        {
            Name = name;
            Money = money;
            this.bags = bags;
            
        }
    }
}
