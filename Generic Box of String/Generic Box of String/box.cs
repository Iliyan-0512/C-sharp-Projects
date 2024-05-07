using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_String
{
    internal class Box<T>
    {
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public override string ToString()
        {
            StringBuilder stringBulder = new StringBuilder();
            foreach (var item in items)
            {
                stringBulder.AppendLine($"System.String:{item}");

            }
           return stringBulder.ToString().TrimEnd();
        }

    }
}
