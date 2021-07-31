using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercraft
{
    class CruiseShip : Watercrafts
    {
        public CruiseShip() : base("Titanic")
        {
            Console.WriteLine($"The {Color} {Name} with {PassengerOccupancy} is leaving the port ");
        }
    }
}
