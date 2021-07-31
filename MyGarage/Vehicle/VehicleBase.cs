using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Vehicle
{
   abstract class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine("You have refueled");
        }

        public abstract void Move();
        public abstract void Stop();
    }
}
