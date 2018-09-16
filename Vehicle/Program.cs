using System;
using System.Collections.Generic;


namespace Vehicle
{
    class Program
    {
        public static void Main()
        {
            //get everything
            var cessna = new Cessna();
            var hovercraft = new HoverCraft();
            var jetski = new JetSki();
            var boat = new Boat();
            var motorcycle = new Motorcycle();
            var car = new Car();



            // Build a collection of all vehicles that fly
            var FlyingVehicles = new List<IFly>{cessna};
            
                FlyingVehicles.Add(cessna);
            FlyingVehicles.Add(hovercraft);

            foreach( var FlyingVehicle in FlyingVehicles)
            {
                FlyingVehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            var RoadVehicles = new List<ILand> { motorcycle };
            RoadVehicles.Add(motorcycle);
            RoadVehicles.Add(car);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var RoadVehicle in RoadVehicles)
                RoadVehicle.Drive();


            // Build a collection of all vehicles that operate on water

            var WaterVehicles = new List<IWater> { jetski, boat };
            WaterVehicles.Add(jetski);
            WaterVehicles.Add(boat);

           // With a single `foreach`, have each water vehicle Drive()
           foreach(var WaterVehicle in WaterVehicles)
            {
                WaterVehicle.Drive();
            }
            Console.Read();
        }
    }
}
