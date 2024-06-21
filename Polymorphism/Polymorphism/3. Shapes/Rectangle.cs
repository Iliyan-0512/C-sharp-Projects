using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        private double height;
        private double width;
      

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive value.");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be a positive value.");
                }
                width = value;
            }
        }
       



        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
           

           
        }
        public override double CalculatePerimeter()
        {
            return 2 * Height + 2 * Width;
        }
        public override double CalculateArea()
        {
            return height * width;
        }
    }
}
