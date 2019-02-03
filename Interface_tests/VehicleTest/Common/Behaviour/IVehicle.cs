using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTest
{
    /// <summary>
    /// Common functionality for all vehicles: move, engines
    /// </summary>
    public interface IVehicle : IFunctionalEngine, IMobility
    {
        
    }
}
