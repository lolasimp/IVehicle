using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class HoverCraft : IFly
    {
        public int Wheels { get; set; } = 6;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 6;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 50.1;
        public double MaxAirSpeed { get; set; } = 400.3;


        public void Fly()
        {
            Console.WriteLine("The HoverCraft glides at top speeds");
        }

        public void Start()
        {
            Console.WriteLine("Click switch to start the engine.");
        }

        public void Stop()
        {
            Console.Write("Verify engine slows down completely to stophovercraft.");
        }
    }
}
