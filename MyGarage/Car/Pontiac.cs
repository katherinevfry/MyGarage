using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Car
{
    class Pontiac : Cars
    {
        public string Model { get; set; }
        public string Year { get; set; }

        public Pontiac(string model, string year) : base("black", 2)
        {
            Model = model;
            Year = year;
            Console.WriteLine($"This is a {Year} {Color} Pontiac {Model} with a fuel capacity of {FuelCapacity} " +
               $"and a passanger occupancy of {PassengerOccupancy}");
        }
    }
}
