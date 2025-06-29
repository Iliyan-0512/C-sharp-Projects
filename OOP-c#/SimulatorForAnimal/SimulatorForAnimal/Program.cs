using SimulatorForAnimal;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animals[] animals =
            {
                  new Lion("Simba", "King of the Jungle", 5),
                new Bat("Batman", "Saves Gottam from the Villains", 23)
            };
            foreach (Animals animal in animals)
            {
                if (animal is Lion lion)
                {
                    Console.WriteLine(animal.Name);
                }
                if (animal is Bat bat)
                {
                    Console.WriteLine(animal.Name);
                }
                if (animal is ISwimmer swimmer)
                {
                    swimmer.Swim();
                }
                if (animal is IPackHunter hunter)
                {
                    hunter.HuntInPack();
                    
                }

            }
        }
    }
}
