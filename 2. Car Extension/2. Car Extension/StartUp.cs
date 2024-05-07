using System;

namespace CarManufacturer
{
    internal class  StartUp
    {
        //        //•	make: string
        //•	model: string
        //•	year: int
        //•	fuelQuantity: double
        //•	fuelConsumption: double

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        //public static object Drive { get; private set; }

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
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        static void Main(string[] args)
        {
           StartUp myCar= new StartUp();
            myCar.FuelConsumption = 100;
            myCar.Year = 1;
            myCar.Make = "1";
            myCar.FuelQuantity = 100;
            myCar.Model = "1";
            Console.WriteLine($"Make{myCar.Make} ");
            myCar.WhoIAm();
            myCar.Drive(100);
        }
        public void Drive(double distance)
        {
            double rezult = fuelQuantity - (distance * fuelConsumption);
            if (rezult>0)
            {
                Console.WriteLine(rezult);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public void WhoIAm()
        {
            Console.WriteLine($"Make: { this.Make}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine($"{this.FuelQuantity:F2}");

        }
    }
}