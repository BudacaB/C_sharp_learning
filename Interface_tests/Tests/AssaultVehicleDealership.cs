using System;
using System.Collections.Generic;
using System.Text;
using VehicleTest;

namespace Tests
{

    class AssaultVehicleDealership
    {
        public List<ICombatVehicle> VehicleStock { get; set; }

        public AssaultVehicleDealership()
        {
            VehicleStock = new List<ICombatVehicle>();
        }
    }
}
