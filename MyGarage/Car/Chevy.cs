using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Car
{
    class Chevy : Cars
    {
        public string Model { get; set; }

        public Chevy(string model) : base("Silver", 4)
        {
            Model = model;
            Console.WriteLine($"This is a {Color} Chevy {Model} with a fuel capacity of {FuelCapacity} " +
                $"and a passanger occupancy of {PassengerOccupancy}");
        }


    }
}
