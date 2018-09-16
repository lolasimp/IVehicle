using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    interface IWater
    {

        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
    }
}
