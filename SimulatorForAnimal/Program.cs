using SimulatorForAnimal;
using System;

namespace MyApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            Animals lion = new Lion("Simba", "King of the Jungle", 5);
            Animals bat = new Bat("Batman", "Saves Gottam from the Villains", 23);
            lion.Type();
            lion.Eat();
            bat.Eat();
            bat.Sleep();


        }
    }
}