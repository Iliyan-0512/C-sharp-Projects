﻿public interface IVehicle
{
    double FuelQuantity { get; set; }
    double FuelConsumption { get; set; }
    void Drive(double distance);
    void Refuel(double liters);
}
