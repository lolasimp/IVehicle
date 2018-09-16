using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class JetSki : IWater
    {
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxWaterSpeed { get; set; } = 90.5;

        public void Drive()
        {
            Console.WriteLine("The Jetski drives  hits some serios waves");
        }

        public void Start()
        {
            Console.WriteLine("Press button to Start");
        }

        public void Stop()
        {
            Console.WriteLine("Release handles to stop");
        }
    }
}
