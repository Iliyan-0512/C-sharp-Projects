using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public double Length
        {
            get { return lenght; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(lenght)} cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public  double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(height)} cannot be zero or negative.");
                }
                height = value;
            }
        }
        public Box(double lenght,double width,double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            
           return  2*lenght * width + 2*lenght*height +2*width *height ;
        }
        public double LateralSurfaceArea()
        {
           
            return 2 * lenght * height + 2 * width * height;
        }
        public  double Volume()
        {
            
            return lenght * width * height;
        }
    }
}
