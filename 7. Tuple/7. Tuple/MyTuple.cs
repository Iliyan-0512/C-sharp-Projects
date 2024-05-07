using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Tuple
{
    public class MyTuple<item2,item1>
    {
        private readonly item2 key;
        private readonly item1 value; 
        public MyTuple(item2 key, item1 value)
        {
            this.key= key;
            this.value= value;
        }
        public override string ToString()
        {
            return $"{this.key} ->{this.value}"; 
        }
    }
}
