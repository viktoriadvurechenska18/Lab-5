using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab5task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();

            network.AddVehicle(new Car());
            network.AddVehicle(new Bus());
            network.AddVehicle(new Train());

            network.MoveAllVehicles();

            Route route = new Route("City A", "City B");
            network.CalculateOptimalRoute(route, new Car());

            network.PassengerBoarding(new Bus(), 24);
            network.PassengerDisembarking(new Train(), 48);
        }
    }
}
