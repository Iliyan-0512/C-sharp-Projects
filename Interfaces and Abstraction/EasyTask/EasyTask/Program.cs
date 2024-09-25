using System;

namespace EasyTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IPet> animals = new List<IPet> { new Dog(), new Cat() };
            foreach (var pet in animals)
            {
                pet.Play();
                pet.MakeSound();
            }
        }
    }
}
