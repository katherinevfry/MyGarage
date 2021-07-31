using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercraft
{
    abstract class Watercrafts : VehicleBase
    {
        public string Name { get; private set; }

        public Watercrafts(string name)
        {
            Name = $"S.S. {name}";
            FuelCapacity = 12;
            Color = "Blue";
            PassengerOccupancy = 6;
        }
        public override void Move()
        {
            Console.WriteLine($"the {Name} is moving");
        }

        public override void Stop()
        {
            Console.WriteLine($"the {Name} is stopping");
        }
    }
}
