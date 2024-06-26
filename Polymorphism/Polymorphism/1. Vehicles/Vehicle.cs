﻿public abstract class Vehicle : IVehicle
{
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }

    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public abstract void Drive(double distance);

    public abstract void Refuel(double liters);
}
