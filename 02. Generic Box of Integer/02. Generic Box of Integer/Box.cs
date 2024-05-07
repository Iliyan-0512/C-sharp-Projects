using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Generic_Box_of_Integer
{
    public class Box<T>
    {
        private T value;
        public Box(T inizatellValue)
        {
            value = inizatellValue;
        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {value}";
        }

    }
}
