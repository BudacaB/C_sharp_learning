using AnimalBehaviourTests;
using Interface_tests;
using SerializationTest;
using System;
using System.Collections.Generic;
using VehicleTest;
using VehicleTest.Aerial;
using Newtonsoft.Json;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            var cards = new List<NbaCard>()
            {
                new NbaCard()
                {
                    Title = "bird",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jpg"
                },
                new NbaCard()
                {
                    Title = "jordan",
                    Link = "https://cdn.newsapi.com.au/image/v1/5115ef8c03f1131ad928b5e31df9901a?width=1024"
                },
                new NbaCard()
                {
                    Title = "payton",
                    Link = "https://www.gannett-cdn.com/-mm-/8177e1eeb06a934d4135ff6c395a147b5d96b563/c=0-261-1148-1124/local/-/media/USATODAY/USATODAY/2013/04/05/xxx-nba-playoffs_-lakers_sonics.jpg?width=534&height=401&fit=crop"
                },
                new NbaCard()
                {
                    Title = "miller",
                    Link = "https://www.gannett-cdn.com/-mm-/2e11b8cc730fc4802e8a510561bb6a81f9357708/c=0-674-2119-2267/local/-/media/2018/05/03/INGroup/Indianapolis/636609486907480586-INI1Brd-11-23-2017-Star-1-C009-2017-11-21-IMG-1-PACERS29.112333.jp-1-1-8EK8U773-L1131985666-IMG-1-PACERS29.112333.jp-1-1-8EK8U773.jpg?width=534&height=401&fit=crop"
                },
                new NbaCard()
                {
                    Title = "johnson",
                    Link = "https://www.sbs.com.au/guide/sites/sbs.com.au.guide/files/styles/full/public/magic-johnson-action-portrait_header.jpeg?itok=HjCBvoYj"
                }
            };


            foreach (var card in cards)
            {
                var serializedCardInfo = JsonConvert.SerializeObject(card);
                Console.WriteLine(serializedCardInfo);
                var deserializedCardInfo = JsonConvert.DeserializeObject<NbaCard>(serializedCardInfo);
                Console.WriteLine(deserializedCardInfo.ToString());
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();


            //[
            //{
            //    title: 'bird',
            //    link: 'https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jpg'
            //},
            //{
            //    title: 'jordan',
            //    link: 'https://cdn.newsapi.com.au/image/v1/5115ef8c03f1131ad928b5e31df9901a?width=1024'
            //},
            //{
            //    title: 'payton',
            //    link: 'https://www.gannett-cdn.com/-mm-/8177e1eeb06a934d4135ff6c395a147b5d96b563/c=0-261-1148-1124/local/-/media/USATODAY/USATODAY/2013/04/05/xxx-nba-playoffs_-lakers_sonics.jpg?width=534&height=401&fit=crop'
            //},
            //{
            //    title: 'miller',
            //    link: 'https://www.gannett-cdn.com/-mm-/2e11b8cc730fc4802e8a510561bb6a81f9357708/c=0-674-2119-2267/local/-/media/2018/05/03/INGroup/Indianapolis/636609486907480586-INI1Brd-11-23-2017-Star-1-C009-2017-11-21-IMG-1-PACERS29.112333.jp-1-1-8EK8U773-L1131985666-IMG-1-PACERS29.112333.jp-1-1-8EK8U773.jpg?width=534&height=401&fit=crop'
            //},
            //{
            //    title: 'johnson',
            //    link: 'https://www.sbs.com.au/guide/sites/sbs.com.au.guide/files/styles/full/public/magic-johnson-action-portrait_header.jpeg?itok=HjCBvoYj'
            //}
            //]


            //Console.WriteLine("Hello World!");
            //var interfaceTest = new InterfaceTest();
            //interfaceTest.PublicProperty = 1;

            ////var dog = new AnimalTests();
            ////dog.Bark();
            //AnimalTests.Run();
            //Math.

            //var newCar = new Car();
            //newCar.StartEngine();
            //newCar.StopEngine();
            //newCar.MoveForward();
            //newCar.UseLights();
            //newCar.UseLights(LightIntensity.Long);

            //var tankHank = new Tank();
            //tankHank.StartEngine();
            //tankHank.ShootProjectile();

            //var bicycleBici = new ElectricBicycle();
            //bicycleBici.StartEngine();

            //var chopper = new Helicopter();
            //var airCargo = new CargoPlane();
            //var dogFighter = new JetFighter();

            //var dealerBuzesti = new CommonVehicleDealership();
            //dealerBuzesti.VehicleStock.Add(newCar);
            ////dealerBuzesti.Vehicles.Add(tankHank);
            //dealerBuzesti.VehicleStock.Add(bicycleBici);

            //var countBuzestiDealershipVehicles = dealerBuzesti.VehicleStock.Count;

            //var dealerMilitari = new AssaultVehicleDealership();
            //dealerMilitari.VehicleStock.Add(tankHank);
            //dealerMilitari.VehicleStock.Add(chopper);
            //dealerMilitari.VehicleStock.Add(airCargo);
            //dealerMilitari.VehicleStock.Add(dogFighter);


            //var countMilitariDealershipVehicles = dealerMilitari.VehicleStock.Count;

        }
    }

}
