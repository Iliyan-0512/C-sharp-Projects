using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphic_figures
{
    public interface IShape
    {
        public double GetArea(double radius);
        public double GetPelimeter(double radius);
        public void Draw(int radius);

    }
}
