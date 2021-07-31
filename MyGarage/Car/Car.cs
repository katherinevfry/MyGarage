using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Car
{
    abstract class Cars : VehicleBase
    {
        public int Horsepower { get; set; }
        public Cars(string color, int passengerOccupancy)
        {
            FuelCapacity = 100;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        }
        public void Speed()
        {
            Console.WriteLine($"The car has {Horsepower} of horsepower");
        }
        public override void Move()
        {
            Console.WriteLine($"You are driving the car");
        }

        public override void Stop()
        {
            Console.WriteLine($"You stepped on the brakes");
        }

    }
}
