using System;
using System.Drawing;

namespace Shapes

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape triangle = new Rectangle( 5, 6);
            Shape circle = new Circle(5);
           

            Console.WriteLine(triangle.Draw());
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter():F2}");
            Console.WriteLine($"Area: {triangle.CalculateArea():F2}");
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter():F2}");
            Console.WriteLine($"Area: {circle.CalculateArea():F2}");
        }
    }
}