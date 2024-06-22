using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] carInfo = Console.ReadLine().Split();
        string[] truckInfo = Console.ReadLine().Split();

        Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
        Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "Drive")
            {
                if (command[1] == "Car")
                {
                    car.Drive(double.Parse(command[2]));
                }
                else if (command[1] == "Truck")
                {
                    truck.Drive(double.Parse(command[2]));
                }
            }
            else if (command[0] == "Refuel")
            {
                if (command[1] == "Car")
                {
                    car.Refuel(double.Parse(command[2]));
                }
                else if (command[1] == "Truck")
                {
                    truck.Refuel(double.Parse(command[2]));
                }
            }
        }

        Console.WriteLine($"Car: {car.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
    }
}
