using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorForAnimal
{
    public class Lion(string name, string description, int age) : Animals(name, description, age)
    {
       

        public override void Type()
        {
            Console.WriteLine($"{Name} is Lion");
        }
        public override void Eat()
        {
            base.Eat();

            Console.WriteLine("He is very hungry");
        }

    }
}
