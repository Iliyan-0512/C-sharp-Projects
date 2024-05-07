using Generic_Scale;
using System;

namespace MyApp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var scaleInt = new EqualityScale<int>(10, 10);
            Console.WriteLine(scaleInt.AreEqual());

            var scaleString = new EqualityScale<string>("apple", "bannana");
            Console.WriteLine(scaleString.AreEqual());

            var scaleDouble = new EqualityScale<double>(1.2345, 4.5555);
            Console.WriteLine(scaleDouble.AreEqual());
        }
    }
}