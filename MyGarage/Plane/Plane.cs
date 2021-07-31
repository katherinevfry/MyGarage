using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Plane
{
   abstract class Planes : VehicleBase
    {
        public string DepartingAirportCode { get; set; }
        public string ArrivingAirportCode { get; set; }
        public string Airline { get; set; }
        public Planes(string airline)
        {
            Airline = airline;
            FuelCapacity = 1000;
            Color = "White";
            PassengerOccupancy = 300;
        }
        public void Trip(string departing, string arriving)
        {
            DepartingAirportCode = departing;
            ArrivingAirportCode = arriving;
            Console.WriteLine($"You are leaving {DepartingAirportCode} " +
                $"and landing in {ArrivingAirportCode}");
        }
        public override void Move()
        {
            Console.WriteLine("The plane took off");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane landed");
        }
    }
}
