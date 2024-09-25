using polymorphism;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>
           {
               new Dog(),new Cat()
           };
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}