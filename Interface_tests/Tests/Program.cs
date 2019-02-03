using AnimalBehaviourTests;
using Interface_tests;
using System;
using VehicleTest;
using VehicleTest.Aerial;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var interfaceTest = new InterfaceTest();
            //interfaceTest.PublicProperty = 1;

            ////var dog = new AnimalTests();
            ////dog.Bark();
            //AnimalTests.Run();
            //Math.

            var newCar = new Car();
            newCar.StartEngine();
            newCar.StopEngine();
            newCar.MoveForward();
            newCar.UseLights();
            newCar.UseLights(LightIntensity.Long);

            var tankHank = new Tank();
            tankHank.StartEngine();
            tankHank.ShootProjectile();

            var bicycleBici = new ElectricBicycle();
            bicycleBici.StartEngine();

            var chopper = new Helicopter();
            var airCargo = new CargoPlane();
            var dogFighter = new JetFighter();

            var dealerBuzesti = new CommonVehicleDealership();
            dealerBuzesti.VehicleStock.Add(newCar);
            //dealerBuzesti.Vehicles.Add(tankHank);
            dealerBuzesti.VehicleStock.Add(bicycleBici);

            var countBuzestiDealershipVehicles = dealerBuzesti.VehicleStock.Count;

            var dealerMilitari = new AssaultVehicleDealership();
            dealerMilitari.VehicleStock.Add(tankHank);
            dealerMilitari.VehicleStock.Add(chopper);
            dealerMilitari.VehicleStock.Add(airCargo);
            dealerMilitari.VehicleStock.Add(dogFighter);


            var countMilitariDealershipVehicles = dealerMilitari.VehicleStock.Count;

        }
    }

}
