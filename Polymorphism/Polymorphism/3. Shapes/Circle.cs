using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be a positive value.");
                }
                radius = value;
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public  override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2); ;
        }
    }
}

