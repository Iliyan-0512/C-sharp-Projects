using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphic_figures
{
    public class Circle:IShape

    {
        
            private double _radius;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public double GetArea()
            {
                return Math.PI * _radius * _radius;
            }

            public double GetPerimeter()
            {
                return 2 * Math.PI * _radius;
            }
            public void Draw(int radius)
        {
            
                int radiusInChars = radius;
                double thickness = 0.4;
                char symbol = '*';
                double rIn = radius - thickness;
                double rOut = radius + thickness;

                for (int y = radiusInChars; y >= -radiusInChars; --y)
                {
                    for (int x = -radiusInChars; x <= radiusInChars; x++)
                    {
                        double value = x * x + y * y;
                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
    }
}
