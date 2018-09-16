using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    interface ILand
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxLandSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
    }
}
