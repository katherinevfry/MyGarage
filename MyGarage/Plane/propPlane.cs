using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Plane
{
    class PropPlane : Planes
    {
        public string Brand { get; set; }
        public bool HasCrashed { get; set; }

        public PropPlane(string brand, bool hasCrashed) : base("Frontier")
        {
            Brand = brand;
            HasCrashed = hasCrashed;
            Console.WriteLine($"This is a {Airline} {Brand} that " +
                $"{(HasCrashed == true ? "has crashed before. yikes." : "has never crashed before")}");
        }

    }
}
