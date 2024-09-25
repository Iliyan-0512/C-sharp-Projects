using System;

namespace MyApp
{
    public interface ImakeSound
    {
        void makeSound();
        void eat(string food);
       
    }
    public class Dog : ImakeSound
    {
        public void eat(string food)
        {
            //throw new NotImplementedException();
            Console.WriteLine("cat ate" + food);
        }

        public void makeSound()
        {
            Console.WriteLine("mew"); ;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makeSound();
            dog.eat(" treat");
        }
    }
}
