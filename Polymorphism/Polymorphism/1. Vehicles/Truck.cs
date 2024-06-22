public class Truck : Vehicle
{
    private const double AirConditionerConsumption = 1.6;
    private const double FuelRetentionRate = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Drive(double distance)
    {
        double neededFuel = distance * (FuelConsumption + AirConditionerConsumption);
        if (FuelQuantity >= neededFuel)
        {
            FuelQuantity -= neededFuel;
            Console.WriteLine($"Truck travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
        }
    }

    public override void Refuel(double liters)
    {
        FuelQuantity += liters * FuelRetentionRate;
    }
}
