using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimulatorForAnimal
{
   public abstract class Animals(string name,string description,int age)
    {
        public string Name { get; } = name;
        public string Description { get; } = description;
        public int Age { get; } = age;
      
        public abstract void Type();
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} eat something");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} sleeps for 10 hours");
        }




    }
}
