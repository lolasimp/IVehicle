using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Boat : IWater
    {
        public int PassengerCapacity { get; set; } = 10;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 2.0;
        public double MaxWaterSpeed { get; set; } = 74.3;

        public void Start()
        {
            Console.WriteLine("The boat is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Hit the brake to stop the boat");
        }

        public void Drive()
        {
            Console.WriteLine("Im driving a boat with a transmission type" + TransmissionType);
        }
    }
}
