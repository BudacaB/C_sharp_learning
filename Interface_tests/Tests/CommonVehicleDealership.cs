using System.Collections.Generic;
using VehicleTest;

namespace Tests
{
    class CommonVehicleDealership
    {
        public List<ICommonVehicle> VehicleStock { get; set; }

        public CommonVehicleDealership()
        {
            VehicleStock = new List<ICommonVehicle>();
        }
    }

}
