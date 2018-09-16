using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : ILand
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 5;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 4.0;
        public double MaxLandSpeed { get; set; } = 200.5;

        public void Drive()
        {
            Console.WriteLine("The car speeds down the highway");
        }

        public void Start()
        {
            Console.WriteLine("Press ignition to start");
        }

        public void Stop()
        {
            Console.WriteLine("Brake to stop");
        }
    }
}
