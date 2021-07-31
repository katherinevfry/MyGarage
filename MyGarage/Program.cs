using System;
using MyGarage.Car;
using MyGarage.Plane;
using MyGarage.Vehicle;
using MyGarage.Watercraft;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Build a collection of all vehicles that fly
                // With a single `foreach`, have each vehicle Fly()

                // Build a collection of all vehicles that operate on roads
                // With a single `foreach`, have each road vehicle Drive()

                // Build a collection of all vehicles that operate on water
                // With a single `foreach`, have each water vehicle Drive()


                var planeOne = new PropPlane("Piper", true);
                var planeTwo = new PropPlane("Cessna", false);

                var myCar = new Chevy("Sonic Hatchback");
                var myOldCar = new Pontiac("Vibe GT", "2009");

                var thisUniverseTitanic = new CruiseShip();
                var anotherUniverseTitanic = new CruiseShip();

                List<Planes> planes = new List<Planes>() { planeOne, planeTwo };
                List<Cars> cars = new List<Cars>() { myCar, myOldCar };
                List<Watercrafts> boats = new List<Watercrafts>() { thisUniverseTitanic, anotherUniverseTitanic };

                foreach (var plane in planes)
                {
                    plane.Move();
                    plane.Stop();
                    plane.Trip("BNA", "LHR");
                }

                foreach (var car in cars)
                {
                    car.Move();
                    car.Stop();
                }

                foreach (var boat in boats)
                {
                    boat.Move();
                    boat.Stop();
                }


            }
        }
    }
}
