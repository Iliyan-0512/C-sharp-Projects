using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorForAnimal
{
    public class Bat(string name,string description,int age):Animals(name,description,age)
    {
        public override void Type()
        {
            Console.WriteLine($"{Name} is Bat");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("bob");
        }
        public override void Sleep()
        {
            base.Sleep();
        }
    }
}
