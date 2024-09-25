using System;

namespace graphic_figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Area: " + circle.GetArea());
            Console.WriteLine("Perimeter: " + circle.GetPerimeter());
            circle.Draw();
        }
    }
}
