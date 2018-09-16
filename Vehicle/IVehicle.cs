using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    interface IVehicle
    {
        // an int property called Wheels
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        double MaxLandSpeed { get; set; }
        double MaxAirSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fly();
       
    }
}
