using System;

namespace PolymorphismExample
{
    // Базов клас
    public class Animal
    {
        // Виртуален метод, който може да бъде преопределен в наследниците
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    // Клас Dog, който наследява от Animal
    public class Dog : Animal
    {
        // Преопределяне на метода MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Клас Cat, който наследява от Animal
    public class Cat : Animal
    {
        // Преопределяне на метода MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Масив от обекти от тип Animal
            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Cat();

            // Извикване на метода MakeSound за всеки от обектите
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
