using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int horsePower { get; set; }
        public double fuel { get; set; }
        public double DefaultFuelConsumption  { get; set; }
        public virtual double  	FuelConsumption  { get; set; }
        public double 	Fuel  { get; set; }
        public int HorsePower  { get; set; }
       	virtual void Drive(double kilometers)
        {

        }
       

    }
}
