using at_academy.crafts;
using at_academy.utils;
using System;


namespace at_academy
{
    class TravelLight
    {
        private static int AIRCRAFTS_COUNT = 5;

        static void Main(string[] args)
        {
            BaseAircraft[] aircrafts = new BaseAircraft[AIRCRAFTS_COUNT];
            BaseAircraft[] sorted_aircrafts;

            aircrafts[0] = new Airplane("Boeing 747");
            aircrafts[1] = new Balloon("A new hope");
            aircrafts[2] = new Helicopter("Racoon-4");
            aircrafts[3] = new Quadcopter("LF-55");
            aircrafts[4] = new Spaceship("Vomzosh");

            for (var i = 0; i < aircrafts.Length; i++)
            {
                BaseAircraft aircraft = aircrafts[i];
                aircraft.isCreated();
                aircraft.loadCargo(15000f);
                aircraft.loadPassengers(15);
                aircraft.takeOff();
                aircraft.fly(1.5f);
                Console.WriteLine();
            }

            Utils.calculateTotalCargoCapacity(aircrafts);
            Utils.printExistingAircrafts(aircrafts);
            sorted_aircrafts = Utils.sortByCarryingCapacity(aircrafts);
            Utils.printExistingAircrafts(sorted_aircrafts);
            Utils.printExistingAircrafts(aircrafts);
            Utils.search(aircrafts, "A new hope");

            Utils.printAircraftInfo(aircrafts[0]);


            Console.ReadLine();
        } 
    }
}
