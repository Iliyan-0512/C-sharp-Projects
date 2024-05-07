using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{

    public class Car
    {
        // Private fields
        private string make;
        private string model;
        private int year;

        // Public properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // Constructor (Optional)
        //public Car(string make, string model, int year)
        //{
        //    this.Make = make;
        //    this.Model = model;
        //    this.Year = year;
        //}
        public Car(string make, string model, int year, double fuelQuantity, 
            double fuelConsumption, Engine engine, Tire[] tires):this (make,model,year,fuelConsumption,fuelQuantity)
        {
            this.Engine = engine;
            this.Tires=tires;
        }
    }


}


