using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_27
{
    internal class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  string Type { get; set; }

        public Pet(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
        public override string ToString()
        {
            return $"This is {Name}, the {Type}, who is {Age} old";

        }
}
}
