using System;
using System.Collections.Generic;

namespace BusinessTrip
{
    internal class Person
    {
        private List<BusinessTrip> trips = new List<BusinessTrip>();

        public void AddTrip(string name, string lastName, string destination, double sum, int days)
        {
            if (days > 2)
            {
                BusinessTrip trip = new BusinessTrip(name, lastName, destination, sum, days);
                trips.Add(trip);
            }
        }

        public void PrintTrips()
        {
            foreach (var trip in trips)
            {
                Console.WriteLine(trip.ToString());
            }
        }
    }
}
