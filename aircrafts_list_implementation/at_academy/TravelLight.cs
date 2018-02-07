using at_academy.crafts;
using at_academy.utils;
using at_academy.singleton;
using System;
using System.Collections.Generic;

namespace at_academy
{
    class TravelLight
    {
        // private static int AIRCRAFTS_COUNT = 5;

        static void Main(string[] args)
        {
            List<BaseAircraft> aircrafts = new List<BaseAircraft>();
            List<BaseAircraft> sorted_aircrafts;            

            aircrafts.Add(new Airplane("Boeing 747"));
            aircrafts.Add(new Balloon("A new hope"));
            aircrafts.Add(new Helicopter("Racoon-4"));
            aircrafts.Add(new Quadcopter("LF-55"));
            aircrafts.Add(new Spaceship("Vomzosh"));


            foreach (BaseAircraft aircraft in aircrafts)
            {
                // BaseAircraft aircraft = aircrafts[i];
                aircraft.IsCreated();
                aircraft.LoadCargo(15000f);
                aircraft.LoadPassengers(15);
                aircraft.TakeOff();
                aircraft.Fly(1.5f);
                aircraft.PrintInfo<string>(aircraft.Name);
                aircraft.PrintInfo<int>(aircraft.MaxPassengersCapacity);
                aircraft.PrintInfo<double>(aircraft.MaxDistance);                
                Console.WriteLine();
            }

            Utils.CalculateTotalCargoCapacity(aircrafts);
            Utils.PrintExistingAircrafts(aircrafts);
            sorted_aircrafts = Utils.SortByCarryingCapacity(aircrafts);            
            Utils.PrintExistingAircrafts(sorted_aircrafts);            
            Utils.PrintExistingAircrafts(aircrafts);
            Utils.Search(aircrafts, "A new hope");

            try
            {
                Utils.Search(aircrafts, "Run forest!");
            }
            catch ( System.EntryPointNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Search is completed!");
            }


            BaseAircraft surprise = SecretShip.Instance;
            surprise.IsCreated();
            System.Console.WriteLine("Instance ID: {0}", surprise.GetHashCode());

            BaseAircraft surprise2 = SecretShip.Instance;
            surprise2.IsCreated();
            System.Console.WriteLine("Instance ID: {0}", surprise2.GetHashCode());


            //generics training--------------------------------------------------


            var numbers = new Generics.GenericList<int>();

            numbers.Add(10);

            var planes = new Generics.GenericList<Airplane>();
            planes.Add(new Airplane("Herpa Etihad Airbus A600"));            

            var quadcopters = new Generics.GenericList<Quadcopter>();
            quadcopters.Add(new Quadcopter("LF-60"));

            var dictionary = new Generics.GenericDictionary<string, Helicopter>();
            dictionary.Add("1234", new Helicopter("Shark-12"));

            //---------------------------------------------------------------------

            

            Console.ReadLine();
        } 
    }
}
