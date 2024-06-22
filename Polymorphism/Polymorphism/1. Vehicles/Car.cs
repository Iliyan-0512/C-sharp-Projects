public class Car : Vehicle
{
    private const double AirConditionerConsumption = 0.9;

    public Car(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Drive(double distance)
    {
        double neededFuel = distance * (FuelConsumption + AirConditionerConsumption);
        if (FuelQuantity >= neededFuel)
        {
            FuelQuantity -= neededFuel;
            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Car needs refueling");
        }
    }

    public override void Refuel(double liters)
    {
        FuelQuantity += liters;
    }
}
