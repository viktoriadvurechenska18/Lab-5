using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5task1
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveAllVehicles()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            Console.WriteLine($"Calculating the optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}.");
        }

        public void PassengerBoarding(Vehicle vehicle, int passengers)
        {
            Console.WriteLine($"Boarding {passengers} passengers onto the {vehicle.GetType().Name}.");
        }

        public void PassengerDisembarking(Vehicle vehicle, int passengers)
        {
            Console.WriteLine($"Disembarking {passengers} passengers from the {vehicle.GetType().Name}.");
        }
    }
}
