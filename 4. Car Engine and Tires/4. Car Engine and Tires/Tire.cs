using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    internal class Tire
    {
        //        •	year: int
        //•	pressure: double
        //The class should also have properties for:
        //•	Year: int
        //•	Pressure: double
        private int year;
        private double pressure;
        public int Year { get; set; }
        public double Pressure {  get; set; }
        public Tire(int year, double pressure)
        {
            this.year = year;
            this.pressure = pressure;
        }

    }
}
