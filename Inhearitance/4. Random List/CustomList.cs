using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomStringList : List<string>
    {
        private Random random;
        public RandomStringList()
        {
            random=new Random();
        }
        public string GetRandomElement()
        {
            var index=random.Next(0,this.Count);
            return this[index];
        }
        public void RemoveRandomElement()
        {
            var index=random.Next(0,Count);
            RemoveAt(index);
        }
    }
}
