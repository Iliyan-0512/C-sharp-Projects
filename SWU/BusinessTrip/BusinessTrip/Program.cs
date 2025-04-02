using System;

namespace BusinessTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person manager = new Person(); 
           

            Console.Write("Enter people: ");
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < n; i++)
            {
                

                Console.Write("name: ");
                string name = Console.ReadLine();

                Console.Write("last name: ");
                string lastName = Console.ReadLine();

                Console.Write("destinaciq: ");
                string destination = Console.ReadLine();

                Console.Write("sum of travel: ");
                double sum = double.Parse(Console.ReadLine());

                Console.Write("number days: ");
                int countDay = int.Parse(Console.ReadLine());
                BusinessTrip businessTrip = new BusinessTrip(name,lastName,destination,sum,countDay);
               
                manager.AddTrip(name, lastName, destination, sum, countDay);
            }

           
            manager.PrintTrips();
        }
    }
}
