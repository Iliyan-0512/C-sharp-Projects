using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Generic_Box_of_String
{
    public class Box<T>
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.value}";
        }
    }
}
