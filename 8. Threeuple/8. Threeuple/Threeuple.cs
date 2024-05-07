using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Threeuple
{
    public class Threeuple<T,V,K>
    {
        public T Object1
        {
            get; set;
        }
        public V Object2 { get; set; }
        public K Object3 { get; set; }
        public Threeuple(T object1, V object2,K object3)
        {
            Object1 = object1;
            Object2 = object2;
            Object3 = object3;
        }
        public override string ToString()
        {
            return $"{this.Object1} -> {this.Object2} -> {this.Object3}";
        }


    }
}
